using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DieticNutritionApp.Classes
{
    public class NotiCommand
    {
        private string Notification;
        public NotiCommand(string Notification)
        {
            this.Notification = Notification;
        }
        public void Open()
        {
            //Open Notification
        }
        public void Close()
        {
            //Close Notificatiom
        }
    }
    public interface Command
    {
        void Excute();
    }
    public class OpenNoti : Command
    {
        private NotiCommand Noti;
        public OpenNoti(NotiCommand Noti)
        {
            this.Noti = Noti;
        }
        public void Excute()
        {
            Noti.Open();
        }
    }
    public class CloseNoti : Command
    {
        private NotiCommand noti;
        public CloseNoti(NotiCommand noti)
        {
            this.noti = noti;
        }
        public void Excute()
        {
            noti.Close();
        }
    }
    public class Logout
    {

        private Command openNoti;
        private Command closeNoti;

        public Logout(Command openNoti, Command closeNoti)
        {
            this.openNoti = openNoti;
            this.closeNoti = closeNoti;
        }

        public void clickOpenNoti()
        {
           
            openNoti.Excute();
        }

        public string clickCloseNoti()
        {
            //print("User click close an user");

            closeNoti.Excute();
            return "You have log out of app.";
        }
    }

}