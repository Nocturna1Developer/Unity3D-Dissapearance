using UnityEditor;
using UnityEngine;

public class ReplaceSelection : EditorWindow
{
		GameObject mNewObject;
			
		[MenuItem ("DoctrinaKharkov/ReplaceSelected %g")]			
		public static void ReplaceObjects ()
		{				
			EditorWindow.GetWindow (typeof(ReplaceSelection));				
		}
			
		void OnGUI ()
		{						
			GUILayout.Label ("Use Object", EditorStyles.boldLabel);
			
			mNewObject = EditorGUILayout.ObjectField (mNewObject, typeof(GameObject), true) as GameObject;
							        						
			if (mNewObject != null) 
			{					
				if (GUILayout.Button ("Replace selected")) 
				{    
					foreach (Transform t in Selection.transforms) 
					{
													
						GameObject newObject = null;
						newObject = PrefabUtility.GetPrefabParent (mNewObject) as GameObject;                    
								
						if (PrefabUtility.GetPrefabType (mNewObject).ToString () == "PrefabInstance") 
						{							
							newObject = (GameObject)PrefabUtility.InstantiatePrefab (newObject);							
							PrefabUtility.SetPropertyModifications (newObject, PrefabUtility.GetPropertyModifications (mNewObject));
																
						} 
						else
						{
							if (PrefabUtility.GetPrefabType (mNewObject).ToString () == "Prefab") 
							{
								newObject = (GameObject)PrefabUtility.InstantiatePrefab (mNewObject);								
							}
							else
							{
								newObject = Instantiate (mNewObject) as GameObject;														
							}                    

							Undo.RegisterCreatedObjectUndo (newObject, "created prefab");
								
							Transform newT = newObject.transform;
																																			
							if (t != null)
							{
								newT.position = t.position;														
								newT.rotation = t.rotation;
								newT.localScale = t.localScale;
								newT.parent = t.parent;  															  											
							}													
						}																
					}

					foreach (GameObject go in Selection.gameObjects) 
					{																																	
						Undo.DestroyObjectImmediate (go);													
					}
				}							
			}			
		}
}