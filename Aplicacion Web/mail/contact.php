<?php
// Comprobación de campos vacíos
if(empty($_POST['name'])  		||
   empty($_POST['email']) 		||
   empty($_POST['phone']) 		||
   empty($_POST['message'])	||
   !filter_var($_POST['email'],FILTER_VALIDATE_EMAIL))
   {
	echo "No se han recibido los parámetros.";
	return false;
   }

$name = $_POST['name'];
$email_address = $_POST['email'];
$phone = $_POST['phone'];
$message = $_POST['message'];

// Se crea el email y se envia el mensaje
$to = 'staff.chronicall@gmail.com';
$email_subject = "Formulario de contacto de ChroniCall:  $name";
$email_body = "Has recibido un nuevo mensaje del formulario de contacto de la página web de ChroniCall.\n\n"."Aquí están los detalles:\n\nNombre: $name\n\nEmail: $email_address\n\nTeléfono: $phone\n\nMensaje:\n$message";
$headers = "From: noreply@chronicall.com\n"; // This is the email address the generated message will be from. We recommend using something like noreply@yourdomain.com.
$headers .= "Reply-To: $email_address";
mail($to,$email_subject,$email_body,$headers);
return true;
?>
