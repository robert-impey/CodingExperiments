<?php
/**
 * Represent a tree.
 *
 * @copyright Copyright (c) 2010-08-10, Robert Impey
 */

class Tree
{
	private $data;
	private $child_trees = array();
	
	public function __construct($name, $parent_name, $dbh, $id = null, $parent_id = null)
	{
		$this->data['name'] = $name;
		$this->data['parent_name'] = $parent_name;
		$this->data['dbh'] = $dbh;
		$this->data['id'] = $id;
		$this->data['parent_id'] = $parent_id;
	}
	
	public function __get($name)
	{
		switch ($name) {
			case 'id':
				if (!isset($this->id)) {
					$query = <<<SQL
SELECT
	id
FROM
	trees
WHERE
	name = '$this->name'
SQL;

					$this->id = 0;
					if ($result = mysql_query($query, $this->dbh)) {
						if ($row = mysql_fetch_assoc($result)) {
							$this->id = $row['id'];
						}
					}
				}
				break;
			case 'parent_id':
				if (!isset($this->parent_id)) {
					$query = <<<SQL
SELECT
	id
FROM
	trees
WHERE
	name = '$this->parent_name'
SQL;

					$this->parent_id = 0;
					if ($result = mysql_query($query, $this->dbh)) {
						if ($row = mysql_fetch_assoc($result)) {
							$this->parent_id = $row['id'];
						}
					}
				}
				break;
			default:
				break;
		}
		
		return $this->data[$name];
	}
	
	public function __set($name, $value)
	{
		return $this->data[$name] = $value;
	}
	
	public function __isset($name)
	{
		return isset($this->data[$name]);
	}
	
	public function add_child($child_name, $parent_name)
	{
		$this->add_child_tree(new Tree($child_name, $parent_name, $this->dbh));
		return $this;
	}
	
	private function add_child_tree(Tree $child_tree)
	{
		if ($this->name === $child_tree->parent_name) {
			array_push($this->child_trees, $child_tree);
			return $this;
		} else {
			for ($i = 0; $i < count($this->child_trees); $i++) {
				if ($this->child_trees[$i]->add_child_tree($child_tree)) {
					return $this;
				}
			}
			
			return false;
		}
	}
	
	public function get_ul()
	{
		$ul = '';
		
		$ul .= '<ul><li>';
		$ul .= $this->name;
		
		foreach($this->child_trees as $child_tree) {
			$ul .= $child_tree->get_ul();
		}
		
		$ul .= '</li></ul>';
		
		return $ul;
	}
	
	public function read_from_db()
	{
		if ($this->id > 0) {
			$query = <<<SQL
SELECT
	id
	, name
FROM
	trees
WHERE
	parent_id = $this->id
SQL;

			if ($result = mysql_query($query, $this->dbh)) {
				while ($row = mysql_fetch_assoc($result)) {
					$child_tree = new Tree($row['name'], $this->name, $this->dbh, $row['id']);
					$child_tree->read_from_db();
					$this->add_child_tree($child_tree);
				}
			}
		}
	}
	
	public function write_to_db()
	{
		$stmt = <<<SQL
INSERT INTO
	trees
		(name, parent_id)
VALUES
		('$this->name', $this->parent_id)
SQL;

		mysql_query($stmt, $this->dbh);
		
		foreach ($this->child_trees as $child_tree) {
			$child_tree->write_to_db();
		}
		
		return $this;
	}
}

?>
