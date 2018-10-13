using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PureMVC.Patterns;
using UnityEngine.UI;

public class TestMediator : Mediator
{

    public new const string NAME = "TestMediator";

    private Text levelText;
    private Button levelUpButton;
    private Button LevelDownButton;


    public TestMediator(GameObject root) : base(NAME)
    {

        levelText = GameUtility.GetChildComponent<Text>(root, "Text/LevelText");
        levelUpButton = GameUtility.GetChildComponent<Button>(root, "LevelUpButton");
        LevelDownButton = GameUtility.GetChildComponent<Button>(root, "LevelDownButton");

        levelUpButton.onClick.AddListener(OnClickLevelUpButton);
        LevelDownButton.onClick.AddListener(OnClickLevelDownButton);
    }

    private void OnClickLevelUpButton()
    {

        SendNotification(NotificationConstant.LevelUp);
    }
    private void OnClickLevelDownButton()
    {
        SendNotification(NotificationConstant.LevelDown);
    }
    public override IList<string> ListNotificationInterests()
    {
        IList<string> list = new List<string>();
        list.Add(NotificationConstant.LevelChange);
        list.Add(NotificationConstant.ButtonColor);
        return list;
    }

    public override void HandleNotification(PureMVC.Interfaces.INotification notification)
    {
        switch (notification.Name)
        {
            case NotificationConstant.LevelChange:
                CharacterInfo ci = notification.Body as CharacterInfo;
                levelText.text = ci.Level.ToString();
                break;
            case NotificationConstant.ButtonColor:
                CharacterInfo cha = notification.Body as CharacterInfo;
                if (cha.Level % 2 == 0)
                {
                    levelText.color = Color.red;
                }
                else
                {
                    levelText.color = Color.blue;
                }
                break;
        }

    }


}
