using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PureMVC.Patterns;

public class TestCommand : SimpleCommand {



    public new const string NAME = "TestCommand";

    public override void Execute(PureMVC.Interfaces.INotification notification)
    {
        TestProxy proxy = (TestProxy)Facade.RetrieveProxy(TestProxy.NAME);
        switch (notification.Name) {
            case NotificationConstant.LevelUp: proxy.ChangeLevel(1);
                break;
            case NotificationConstant.LevelDown:proxy.ChangeLevel(-1);
                break;
        }
       
        //proxy.ChangeLevel(1);
    }


}
