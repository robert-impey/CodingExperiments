// Colours

$(document).ready(function () {
	$("#colours li").hover(
		function () {
			var currentColourP = $("#currentColour");
			
			var lcElementContent = $(this).html().toLowerCase();
			currentColourP.addClass(lcElementContent);
			
			currentColourP.html("The current colour is " + lcElementContent);
		}
		, function () {
			var currentColourP = $("#currentColour");
			
			var lcElementContent = $(this).html().toLowerCase();
			currentColourP.removeClass(lcElementContent);
			
			currentColourP.html("");
		}
	);
});
