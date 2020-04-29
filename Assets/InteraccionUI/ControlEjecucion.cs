    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    using UnityEngine.EventSystems;

    public class ControlEjecucion : MonoBehaviour, IPointerClickHandler
    {

        private bool habilitado;

        public void OnPointerClick(PointerEventData eventData)
        {
            Hud hud;
            hud = Hud.GetInstance();
            if (habilitado)
            {
                hud.Modo_ejecucion = Hud.EJECUCION;
                habilitado = false;
            }
        }

        // Use this for initialization
        void Start()
        {

            habilitado = true;
        }

    }
