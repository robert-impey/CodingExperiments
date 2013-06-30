// Navigation

$(document).ready(function() {
	var pages = [
		{ name: 'apples' }
		, { name: 'bananas' }
		, { name: 'coconuts' }
	];
	
	(function() {
		var pagesUl = $('#templates #pages').children().clone().appendTo('#navigationPanel')[0];
		$(pagesUl).addClass('sys-template');
		
		var dv = new Sys.UI.DataView(pagesUl);
		dv.set_data(pages);
		dv.add_itemRendered(function (one, two) {
			$(two.nodes[0].firstChild).click(function () {
				alert(two.dataItem.name);
			});
		});
		dv.refresh();
	})();
});
