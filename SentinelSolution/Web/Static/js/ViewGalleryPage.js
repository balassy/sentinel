/// <reference path="_references.js" />

$(function () {
	var $gallery = $('#gallery');
	var $preview = $('#preview');
	var $previewImg = $preview.find('a img');

	$('#gallery a').click(function () {
		var fullUrl = $(this).data('full');
		$previewImg.attr('src', '' );
		$gallery.slideUp();
		$previewImg.attr('src', fullUrl);
		$preview.slideDown();
		return false;
	});

	$('#preview a').click(function () {
		$preview.slideUp();
		$gallery.slideDown();
		return false;
	});
});