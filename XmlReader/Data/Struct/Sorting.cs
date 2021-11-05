using System.Collections.Generic;

namespace CookHelper.Data
{
    public class Sorting
    {
        public readonly string Name;
        public readonly int ClassID;
        public readonly bool IsMenu;
        public readonly MENU Menu;
        public readonly ITEM Item;
        public BUFFER Buffer
        {
            get
            {
                return Item?.FoodEffect;
            }
        }
        public List<EFFECT> Effect
        {
            get
            {
                return Buffer?.Effects;
            }
        }

        public Sorting(string Name, int ClassID, bool IsMenu, MENU Menu, ITEM Item)
        {
            this.Name = Name;
            this.ClassID = ClassID;
            this.IsMenu = IsMenu;
            this.Menu = Menu;
            this.Item = Item;
        }

        public bool IsSuccess
        {
            get
            {
                if (Menu == null)
                    return false;
                else
                    return Menu.IsSuccess(ClassID);
            }
        }

        public bool IsEvent
        {
            get
            {
                if (Menu == null)
                    return false;
                else
                    return Menu.Locale != null || Menu.Event != null;
            }
        }

        public bool HasEffect(string EffectName)
        {
            if (Effect != null)
            {
                foreach (EFFECT ef in Effect)
                {
                    if (ef.Name == EffectName)
                        return true;
                }
            }
            return false;
        }

        public int EffectValue(string EffectName)
        {
            if (Effect != null)
            {
                foreach (EFFECT ef in Effect)
                {
                    if (ef.Name == EffectName)
                        return ef.AmountInt;
                }
            }
            return 0;
        }

        public override string ToString()
        {
            return Name;
        }


    }
}
