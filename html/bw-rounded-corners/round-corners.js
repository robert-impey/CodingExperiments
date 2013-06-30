/**
 * Functions for wrapping a div with Round corners.
 *
 * @copyright RFI 2008-01-24
 */

/*
 * Thanks to:
 * 
 * http://delete.me.uk/2004/09/ieproto.html
 */
//HTMLElement = function () {};
//
//HTMLElement.prototype.getAttribute = function (attribute) {
//    if (attribute == "class") attribute = "className";
//    if (attribute == "for") attribute = "htmlFor";
//    return this[attribute];
//}
//
//HTMLElement.prototype.setAttribute = function (attribute, value) {
//    if (attribute == "class") attribute = "className";
//    if (attribute == "for") attribute = "htmlFor";
//    this[attribute] = value;
//}

function round_all_corners()
{
	var divs_to_round = document.getElementsByTagName('div');

	for (var i = 0; i < divs_to_round.length; i++) {
		var current_div = divs_to_round.item(i);
		
		//if (current_div.hasAttribute('class')) {
		//	if (current_div.getAttribute('class') == 'bw-rc') {
		if (current_div.className == 'bw-rc') {
				round_corners(current_div);
			}
		//}
	}
}

function round_corners(current_div)
{
	/*
	 * Cut the existing content of the div.
	 */
	currrent_div_inner_html = current_div.innerHTML;
	
	//current_div.innerHTML = null;
	// For Opera.
	current_div.innerHTML = '';
	
	/*
	 * The Header.
	 */
	var div_h = document.createElement('div');
	//div_h.setAttribute('class', 'h');
	div_h.className = 'h';

	var div_h_l = document.createElement('div');
	//div_h_l.setAttribute('class', 'l');
	div_h_l.className = 'l';
	div_h.appendChild(div_h_l);

	var div_h_r = document.createElement('div');
	//div_h_r.setAttribute('class', 'r');
	div_h_r.className = 'r';
	div_h.appendChild(div_h_r);

	current_div.appendChild(div_h);
	
	/*
	 * The middle.
	 */
	var div_m = document.createElement('div');
	//div_m.setAttribute('class', 'm');
	div_m.className = 'm';

	var div_m_content = document.createElement('div');
	//div_m_content.setAttribute('class', 'content');
	div_m_content.className = 'content';

	/*
	 * Paste the previous contents into this inner div.
	 */
	div_m_content.innerHTML = currrent_div_inner_html;

	div_m.appendChild(div_m_content);

	var div_m_r = document.createElement('div');
	//div_m_r.setAttribute('class', 'r');
	div_m_r.className = 'r';
	div_m.appendChild(div_m_r);

	current_div.appendChild(div_m);
	
	/*
	 * The footer.
	 */
	var div_f = document.createElement('div');
	//div_f.setAttribute('class', 'f');
	div_f.className = 'f';

	var div_f_l = document.createElement('div');
	//div_f_l.setAttribute('class', 'l');
	div_f_l.className = 'l';
	div_f.appendChild(div_f_l);

	var div_f_r = document.createElement('div');
	//div_f_r.setAttribute('class', 'r');
	div_f_r.className = 'r';
	div_f.appendChild(div_f_r);

	current_div.appendChild(div_f);
}
