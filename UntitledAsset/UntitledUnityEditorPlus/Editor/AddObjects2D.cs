using UnityEditor;
using UnityEngine;

namespace UntitledAsset.UntitledEditor
{
	public class AddObjects2D : Editor
	{
		private static GameObject groundCheckPrefab;

		[MenuItem("GameObject/Untitled Editor/Add Ground Check 2D", false, 0)]
		public static void AddGroundCheck(MenuCommand menuCommand)
		{
			if (groundCheckPrefab == null)
			{
				groundCheckPrefab = AssetDatabase.LoadAssetAtPath<GameObject>("Assets/UntitledAsset/UntitledObjects/Ground Checker.prefab");
			}
			
			if (groundCheckPrefab != null)
			{
				GameObject selectedObject = menuCommand.context as GameObject;
				if (selectedObject != null)
				{
					GameObject groundCheckInstance = PrefabUtility.InstantiatePrefab(groundCheckPrefab) as GameObject;
					if (groundCheckInstance != null)
					{
						Undo.RegisterCreatedObjectUndo(groundCheckInstance, "Undo Add Ground Check 2D");
						groundCheckInstance.transform.parent = selectedObject.transform;
						groundCheckInstance.transform.localPosition = Vector3.zero;
					}
				}
			}
		}


		private static GameObject wallCheckPrefab;

		[MenuItem("GameObject/Untitled Editor/Add Wall Check 2D", false, 0)]
		public static void AddWallCheck(MenuCommand menuCommand)
		{
			if (wallCheckPrefab == null)
			{
				wallCheckPrefab = AssetDatabase.LoadAssetAtPath<GameObject>("Assets/Plugins/UntitledAsset/UntitledDependencies/Wall Checker.prefab");
			}
			
			if (wallCheckPrefab != null)
			{
				GameObject selectedObject = menuCommand.context as GameObject;
				if (selectedObject != null)
				{
					GameObject wallCheckInstance = PrefabUtility.InstantiatePrefab(wallCheckPrefab) as GameObject;
					if (wallCheckInstance != null)
					{
						Undo.RegisterCreatedObjectUndo(wallCheckInstance, "Undo Add Ground Check 2D");
						wallCheckInstance.transform.parent = selectedObject.transform;
						wallCheckInstance.transform.localPosition = Vector3.zero;
					}
				}
			}
		}
	}
}
