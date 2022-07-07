<?php


$DATABASE_HOST = '';
$DATABASE_USER = '';
$DATABASE_PASS = '';
$DATABASE_NAME = '';
// Try and connect using the info above.
$con = mysqli_connect($DATABASE_HOST, $DATABASE_USER, $DATABASE_PASS, $DATABASE_NAME);
if($con) {
    // echo "success"; 
} 
else {
    die("Error". mysqli_connect_error()); 
} 
if($_SERVER["REQUEST_METHOD"] == "POST") {
$username = $_POST["username"];
$password = $_POST["password"];

// check for username
$usernamecheckquery = "Select username , hash  FROM users WHERE username='$username'";
$usernamecheck = mysqli_query($con, $usernamecheckquery) or die ("Something went wrong");
if (mysqli_num_rows($usernamecheck) != 1)
{
    echo "Can't find this username";
    exit();
}
$results = mysqli_fetch_assoc($usernamecheck);
$hash = $results["hash"];


// $loginHash = password_verify($password, $hash);

if (password_verify($password, $hash)) {
   echo "0";
} else {
    echo 'Invalid password.';
}

}
?>