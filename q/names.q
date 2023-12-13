data_dir:getenv `DATA

boys_names_file:"/" sv (data_dir; "boys-names.txt")
boys_names_path: hsym `$boys_names_file

boys_names: ("S",",")0: boys_names_path

surnames_file:"/" sv (data_dir; "surnames.txt")
surnames_path: hsym `$surnames_file

surnames: ("S")0: surnames_path
