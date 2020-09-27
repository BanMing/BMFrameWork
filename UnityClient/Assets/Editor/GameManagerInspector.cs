using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace BMBaseCore
{
    [CustomEditor(typeof(GameManager))]
    public class GameManagerInspector : Editor
    {
        private GameConfig gameConfig;

        private void OnEnable()
        {
            gameConfig = AssetDatabase.LoadAssetAtPath<GameConfig>(GameConfig.AssetPath);
        }

        public override void OnInspectorGUI()
        {
            //base.OnInspectorGUI();
            gameConfig.isAssertBundle = EditorGUILayout.Toggle("Is Load AssertBundle", gameConfig.isAssertBundle);
        }
    }
}

