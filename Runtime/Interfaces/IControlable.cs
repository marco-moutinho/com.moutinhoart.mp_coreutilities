using UnityEngine;
namespace MP_CoreUtilities.Interfaces
{
    // Created on 27-Feb-2026
    public interface IControlable
    {
        // created on 27-Feb-2026
        public void IMethod_HandleMoveInput(in Vector2 InVector2D);

        // created on 27-Feb-2026
        public void IMethod_HandleLookInput(in Vector2 InVector2D);
    }
}