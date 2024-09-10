using UnityEditor;

public class StateMachineContextMenu
{
    [MenuItem("Assets/Create/State Machine Gen/New State")]
    private static void CreateState()
    {
        string newScriptName = "NewState.cs";
        ProjectWindowUtil.CreateScriptAssetFromTemplateFile("Assets/Scripts/Templates/NewState.cs.txt", newScriptName);
    }

    [MenuItem("Assets/Create/State Machine Gen/New State Factory")]
    private static void CreateStateFactory()
    {
        string newScriptName = "NewStateFactory.cs";
        ProjectWindowUtil.CreateScriptAssetFromTemplateFile("Assets/Scripts/Templates/NewStateFactory.cs.txt", newScriptName);
    }

    [MenuItem("Assets/Create/State Machine Gen/New State Machine")]
    private static void CreateStateMachine()
    {
        string newScriptName = "NewStateMachine.cs";
        ProjectWindowUtil.CreateScriptAssetFromTemplateFile("Assets/Scripts/Templates/NewStateMachine.cs.txt", newScriptName);
    }

    [MenuItem("Assets/Create/State Machine Gen/New Base State")]
    private static void CreateBaseState()
    {
        string newScriptName = "NewBaseState.cs";
        ProjectWindowUtil.CreateScriptAssetFromTemplateFile("Assets/Scripts/Templates/NewBaseState.cs.txt", newScriptName);
    }
}
