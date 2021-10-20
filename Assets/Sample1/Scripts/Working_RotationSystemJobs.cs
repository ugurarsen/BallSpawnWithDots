using Unity.Entities;
using Unity.Transforms;
using Unity.Mathematics;
using UnityEngine;
using Unity.Jobs;
using Unity.Rendering;

public class Working_RotationSystemJobs : JobComponentSystem
{
    protected override JobHandle OnUpdate(JobHandle inputDeps)
    {
        var deltaTime = Time.DeltaTime;
        return Entities.ForEach((ref Rotation rotation, ref Working_RotationVelocity workingRotationVelocity) =>
        {
            float rotationAmount = workingRotationVelocity.value * deltaTime * Mathf.Deg2Rad;
            quaternion rotationQuat = quaternion.Euler(0, rotationAmount, 0);
            quaternion newRotation = math.mul(rotation.Value, rotationQuat);
            rotation.Value = newRotation;
        }).Schedule(inputDeps);
    }
}
