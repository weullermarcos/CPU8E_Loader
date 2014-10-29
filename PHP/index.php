

<?php
require("php_serial.class.php");

$filename = 'C:\\Documents and Settings\\Administrator\\Desktop\\abc.bin';
	$arquivo = fopen($filename, 'rb');
	
	
	
	$texto = fread($arquivo, filesize($filename));
	$texto = strtoupper(bin2hex($texto));
	
	echo($texto);
	fclose ($arquivo );

$serial = new phpSerial();
$serial->deviceSet("COM5");
$serial->confBaudRate(9600); //Baud rate: 9600
$serial->confParity("none"); //Parity (this is the "N" in "8-N-1")
$serial->confCharacterLength(8); //Character length
$serial->confStopBits(1); //Stop bits (this is the "1" in "8-N-1")
$serial->confFlowControl("none");
$serial->deviceOpen();
$serial->sendMessage($texto);
$serial->deviceClose();
?>