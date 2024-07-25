﻿using Unity.Entities;

public class QuizSystemTest : ECSTestsFixture
{
    [SetUp]
    public override void Setup()
    {
        base.Setup();
        m_TestWorld = new World("Test World");
        var systemGroup = m_TestWorld.GetOrCreateSystemManaged<SimulationSystemGroup>();
        m_SystemHandle = m_TestWorld.CreateSystem<QuizSystemTest.cs>();
        systemGroup.AddSystemToUpdateList(m_SystemHandle);
    }

    [TearDown]
    public override void TearDown()
    {
        m_TestWorld.Dispose();
        base.TearDown();
    }

    private World m_TestWorld;
    private SystemHandle m_SystemHandle;

    [Test]
    void quizSystemTest.cs()
    {
        // Arrange
        var entity = m_TestWorld.EntityManager.CreateEntity(
            typeof(DummyTagComponent), typeof(Test));
        m_TestWorld.EntityManager.SetComponentData(
            entity, new Test { Value = 0 });

        // Act
        m_TestWorld.Update();

        // Assert
        var age = m_TestWorld.EntityManager.GetComponentData<Test>(entity);
        Assert.AreEqual(1, age.Value, "Age should be increased by 1");
    }