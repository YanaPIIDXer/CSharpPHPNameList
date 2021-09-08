<?php
    $json = file_get_contents("php://input");
    $contents = json_decode($json, true);
    
    $id = $contents["id"];
    $last_name = $contents["last_name"];
    $first_name = $contents["first_name"];
    $result = ["result" => false];
    if ($id === null ||
        $last_name === null || $last_name === "" ||
        $first_name === null || $first_name === "")
    {
        echo json_encode($result);
        return;
    }
    
    $conn = new SQLConnection();
    $stmt = $conn->query("UPDATE users SET last_name = :last_name, first_name = :first_name WHERE id = :id;");
    $stmt->bind(":last_name", $last_name, PDO::PARAM_STR);
    $stmt->bind(":first_name", $first_name, PDO::PARAM_STR);
    $stmt->bind(":id", $id, PDO::PARAM_INT);

    $result["result"] = $stmt->execute();
    echo json_encode($result);
?>