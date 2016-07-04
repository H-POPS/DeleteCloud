using UnityEngine;

namespace HelloMod
{
    public class Main : IMod
    {
        public string Identifier { get; set; }
        GameObject _go; 
        public void onEnabled()
        {
            _go = new GameObject();

            ToggleCloud TC = _go.AddComponent<ToggleCloud>();
            TC.DisableClouds();
        }

        public void onDisabled()
        {
            UnityEngine.Object.Destroy (_go);
        }

        public string Name 
        {
            get { return "Dissable clouds"; }
        }

        public string Description
        {
            get { return "Don't like the cloud? This mod dislikes it too"; }
        }
    }
}
