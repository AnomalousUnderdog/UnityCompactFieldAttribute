using System;
using UnityEngine;
using UnityEditor;

[CustomPropertyDrawer(typeof(CompactFieldAttribute))]
public class CompactFieldDrawer : PropertyDrawer
{
	Vector2 _propertyLabelSize;

	const float INDENT_WIDTH = 16;

	public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
	{
		return EditorGUI.GetPropertyHeight(property);
	}

	public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
	{
		if (Event.current.type == EventType.Repaint)
		{
			_propertyLabelSize = EditorStyles.label.CalcSize(label);
		}
		
		EditorGUIUtility.labelWidth = _propertyLabelSize.x + (EditorGUI.indentLevel * INDENT_WIDTH) + 5;
		EditorGUI.PropertyField(position, property, label, true);
		EditorGUIUtility.labelWidth = 0;
	}
}
