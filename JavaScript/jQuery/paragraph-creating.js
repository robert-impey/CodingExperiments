jQuery(document).ready(function () {
	$('#create').click(function () {
		var numberOfParagraphs = $('#numberOfParagraphs').val();
		
		var markupContainer = $('#markupContainer');
		markupContainer.html('');
		var start = new Date();
		for (var i = 0; i < numberOfParagraphs; i++) {
			markupContainer.append('<p id="p' + i + '">Paragraph ' + i + '</p>');
		}
		var stop = new Date();

		$('#time').html(
			'Time taken: '
			+ (stop - start) + ' ms'
		);
	});
});
