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


		private static GameObject enemyAttackZoneTriggerPrefab;

		[MenuItem("GameObject/Untitled Editor/Add Enemy Attack Zone Trigger 2D", false, 0)]
		public static void EnemyAttackZoneTrigger(MenuCommand menuCommand)
		{
			if (enemyAttackZoneTriggerPrefab == null)
			{
				enemyAttackZoneTriggerPrefab = AssetDatabase.LoadAssetAtPath<GameObject>("Assets/UntitledAsset/UntitledObjects/Attack Zone Trigger.prefab");
			}
			
			if (enemyAttackZoneTriggerPrefab != null)
			{
				GameObject selectedObject = menuCommand.context as GameObject;
				if (selectedObject != null)
				{
					GameObject enemyAttackZoneTriggerInstance = PrefabUtility.InstantiatePrefab(enemyAttackZoneTriggerPrefab) as GameObject;
					if (enemyAttackZoneTriggerInstance != null)
					{
						Undo.RegisterCreatedObjectUndo(enemyAttackZoneTriggerInstance, "Undo Add Enemy Attack Zone Trigger 2D");
						enemyAttackZoneTriggerInstance.transform.parent = selectedObject.transform;
						enemyAttackZoneTriggerInstance.transform.localPosition = Vector3.zero;
					}
				}
			}
		}

		private static GameObject enemyEnterTriggerPrefab;

		[MenuItem("GameObject/Untitled Editor/Add Enemy Enter Trigger 2D", false, 0)]
		public static void EnemyEnterTrigger(MenuCommand menuCommand)
		{
			if (enemyEnterTriggerPrefab == null)
			{
				enemyEnterTriggerPrefab = AssetDatabase.LoadAssetAtPath<GameObject>("Assets/UntitledAsset/UntitledObjects/Enter Trigger.prefab");
			}
			
			if (enemyEnterTriggerPrefab != null)
			{
				GameObject selectedObject = menuCommand.context as GameObject;
				if (selectedObject != null)
				{
					GameObject enemyEnterTriggerInstance = PrefabUtility.InstantiatePrefab(enemyEnterTriggerPrefab) as GameObject;
					if (enemyEnterTriggerInstance != null)
					{
						Undo.RegisterCreatedObjectUndo(enemyEnterTriggerInstance, "Undo Add Enemy Enter Trigger 2D");
						enemyEnterTriggerInstance.transform.parent = selectedObject.transform;
						enemyEnterTriggerInstance.transform.localPosition = Vector3.zero;
					}
				}
			}
		}
	}
}