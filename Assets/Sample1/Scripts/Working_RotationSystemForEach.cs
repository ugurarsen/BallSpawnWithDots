/*using Unity.Entities;
using Unity.Transforms;
using Unity.Mathematics;
using UnityEngine;

public class Working_RotationSystemForEach : ComponentSystem
{
    protected override void OnUpdate()
    {
        Entities.ForEach<Rotation, Working_RotationVelocity>(RotateEntitiy);
    }

    private void RotateEntitiy(Entity entity, ref Rotation rotation,
        ref Working_RotationVelocity workingRotationVelocity)
    {
        float rotationAmount = workingRotationVelocity.value*Time.DeltaTime*Mathf.Deg2Rad;
        quaternion rotationQuat = quaternion.Euler(0,rotationAmount,0);
        quaternion newRotation = math.mul(rotation.Value, rotationQuat);
        rotation.Value = newRotation;
    }
}
*/