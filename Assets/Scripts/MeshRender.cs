﻿using Unity.Mathematics;
using Unity.Rendering;
using Unity.Transforms;
using UnityEngine;
using UnityEngine.Rendering;
using SystemBase = Unity.Entities.SystemBase;

public partial class MeshLoaderSystem : SystemBase
{
    protected override void OnCreate()
    {
        // Mesh와 Material 로드
        var suzanMesh = Resources.Load<Mesh>("Mesh/Suzan");
        var greenMaterial = Resources.Load<Material>("Material/Green");

        if (suzanMesh == null || greenMaterial == null)
        {
            Debug.LogError("Failed to load Suzan mesh or Green material from Resources folder");
            return;
        }

        // RenderMeshDescription 생성
        var desc = new RenderMeshDescription(
            ShadowCastingMode.On,
            true);

        // RenderMeshArray 생성
        var renderMeshArray = new RenderMeshArray(new[] { greenMaterial }, new[] { suzanMesh });

        // Entity 생성 및 필요한 컴포넌트 추가..
        var entity = EntityManager.CreateEntity();

        RenderMeshUtility.AddComponents(
            entity,
            EntityManager,
            desc,
            renderMeshArray,
            MaterialMeshInfo.FromRenderMeshArrayIndices(0, 0));

        // LocalToWorld 컴포넌트 추가 (위치, 회전, 크기 설정)
        EntityManager.AddComponentData(entity, new LocalToWorld
        {
            Value = float4x4.TRS(
                new float3(0, 0, 0), // 위치
                quaternion.identity, // 회전
                new float3(1, 1, 1) // 크기
            )
        });

        Debug.Log("Suzan mesh entity created successfully");
    }

    protected override void OnUpdate()
    {
        // Entity 렌더링은 Entities Graphics에 의해 자동으로 처리됩니다.
    }
}