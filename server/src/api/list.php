<?php
    require_once '../classes/SQLConnection.php';

    $conn = new SQLConnection();
    $message = $conn->connect() ? "OK" : "Fuck";

    echo json_encode(["message" => $message]);
?>