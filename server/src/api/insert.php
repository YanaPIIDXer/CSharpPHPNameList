<?php
    require_once "../classes/SQLConnection.php";

    $json = file_get_contents("php://input");
    $contents = json_decode($json, true);
    
    $last_name = $contents["last_name"];
    $first_name = $contents["first_name"];
    $result = ["result" => false];
    if ($last_name === null || $last_name === "" ||
        $first_name === null || $first_name === "")
    {
        echo json_encode($result);
        return;
    }
    
    $conn = new SQLConnection();
    if (!$conn->connect())
    {
        echo json_encode($result);
        return;
    }
    $stmt = $conn->query("INSERT INTO users(last_name, first_name) VALUES(:last_name, :first_name);");
    $stmt->bind(":last_name", $last_name, PDO::PARAM_STR);
    $stmt->bind(":first_name", $first_name, PDO::PARAM_STR);

    $result["result"] = $stmt->execute();
    echo json_encode($result);
?>