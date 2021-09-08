<?php
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
    
    $result["result"] = true;
    echo json_encode($result);
?>