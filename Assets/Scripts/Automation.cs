using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;

public class Automation
{
    [MenuItem("Window/Automation")]
    public static void Run() {
        DirectoryInfo dir = new DirectoryInfo("Assets/Sprites/cards");
        FileInfo[] infoArray = dir.GetFiles("*.png");

        foreach (FileInfo info in infoArray) {
            string relativePath = info.FullName.Split("\\Clover\\")[1];
            if (relativePath.Contains("spades")) {
                string[] parts = relativePath.Split("\\");
                string name = parts[parts.Length - 1];
                string newName = name.Replace("spades", "spade");
                AssetDatabase.RenameAsset(relativePath, newName);
            }
        }
    }
}
