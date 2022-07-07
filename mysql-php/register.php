<?php

$DATABASE_HOST = '';
$DATABASE_USER = '';
$DATABASE_PASS = '';
$DATABASE_NAME = '';
// Try and connect using the info above.
$conn = mysqli_connect($DATABASE_HOST, $DATABASE_USER, $DATABASE_PASS, $DATABASE_NAME);
if($conn) {
    // echo "success"; 
} 
else {
    die("Error". mysqli_connect_error()); 
} 

   
if($_SERVER["REQUEST_METHOD"] == "POST") {
      
   
    
    $username = $_POST["username"]; 
    $password = $_POST["password"]; 
   
            
    
    $sql = "Select * from users where username='$username'";
    
    $result = mysqli_query($conn, $sql);
    
    $num = mysqli_num_rows($result); 
    
    // This sql query is use to check if
    // the username is already present 
    // or not in our Database
    if($num == 0) {
       
    
            $hash = password_hash($password, 
                                PASSWORD_DEFAULT);
                
            // Password Hashing is used here. 
            $sql = "INSERT INTO `users` ( `username`,`hash`) VALUES ('$username','$hash')";
    
            $result = mysqli_query($conn, $sql);
            if ($result) {
                echo 0; 
            }
    
            
        } 
            
    //}
    
   if($num>0) 
   {
      echo "Username not available"; 
   } 
   
}
?>