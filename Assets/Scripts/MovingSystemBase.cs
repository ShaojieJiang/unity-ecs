using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;
using Unity.Transforms;
using Unity.Mathematics;

public partial class MovingSystemBase : SystemBase
{
    protected override void OnUpdate()
    {
        foreach((var localTransform, var speed) in SystemAPI.Query<RefRW<LocalTransform>, RefRO<Speed>>())
        {
            localTransform.ValueRW.Position += new float3(1, 0, 0) * SystemAPI.Time.DeltaTime * speed.ValueRO.value;
        }
    }
}
