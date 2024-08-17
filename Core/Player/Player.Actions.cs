namespace Server
{
    public partial class Player : Humanoid
    {
        public override void SetAction(string actionName, string itemRef, int index)
        {
            var action = !string.IsNullOrEmpty(actionName) ? Actions.FindActionByName(actionName) : null;
            var item = !string.IsNullOrEmpty(itemRef) ? Items.GetItemByRef(itemRef) : null;

            if (action != null || item != null)
            {
                Actionbar[index] = new ActionbarRef(action, item, index);
                Save();
                SaveToDatabase().Wait(); 
                RefreshLocalPlayerData();
            }
        }

        public override void ClearAction(int index)
        {
            if (Actionbar.ContainsKey(index))
            {
                Actionbar.Remove(index);
                Save();
                SaveToDatabase().Wait(); 
                RefreshLocalPlayerData();
            }
        }

    }
}
