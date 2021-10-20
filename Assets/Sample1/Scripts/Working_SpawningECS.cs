using System;
using Unity.Entities;
using Unity.Transforms;
using Unity.Mathematics;
using UnityEngine;

public class Working_SpawningECS : MonoBehaviour
{

    [SerializeField] private GameObject spherePrefab;
    [SerializeField] private float spawnSphereSize = 10;
    [SerializeField] private float spawnSpheration = 1.5f;
    void Awake()
    {
        World world = World.DefaultGameObjectInjectionWorld;
        EntityManager entityManager = world.EntityManager;
        GameObjectConversionSettings conversionSettings =
            new GameObjectConversionSettings(world, GameObjectConversionUtility.ConversionFlags.AssignName);

        Entity entityPrefab = GameObjectConversionUtility.ConvertGameObjectHierarchy(spherePrefab, conversionSettings);

        for (int x = 0; x < spawnSphereSize; x++)
        {
            for (int y = 0; y < spawnSphereSize; y++)
            {
                for (int z = 0; z < spawnSphereSize; z++)
                {

                    Entity prefabInstance = entityManager.Instantiate(entityPrefab);
                    Translation instancePosition = new Translation();
                    instancePosition.Value = new float3(x * spawnSpheration, y * spawnSpheration, z * spawnSpheration);
                    entityManager.SetComponentData(prefabInstance, instancePosition);
                }
            }
        }
    }
}
