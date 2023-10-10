namespace Maple2.Trigger._02020112_bf {
    public static class _jumproom {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.EnableSpawnPointPc(spawnId: 1, enabled: false);
                context.SetEffect(triggerIds: new []{8005, 8006, 8007, 8008}, visible: false);
                context.SetUserValue(triggerId: 99990009, key: "ButtonSuccess", value: 0);
                context.SetUserValue(triggerId: 99990010, key: "ButtonSuccess", value: 0);
                context.SetUserValue(triggerId: 99990011, key: "ButtonSuccess", value: 0);
                context.SetUserValue(triggerId: 99990012, key: "ButtonSuccess", value: 0);
                context.SetUserValue(triggerId: 99990001, key: "MonsterDead", value: 0);
                context.SetActor(triggerId: 9905, visible: true, initialSequence: "Interaction_Lapentafoothold_A01_Off");
                context.SetActor(triggerId: 9906, visible: true, initialSequence: "Interaction_Lapentafoothold_A01_Off");
                context.SetActor(triggerId: 9907, visible: true, initialSequence: "Interaction_Lapentafoothold_A01_Off");
                context.SetActor(triggerId: 9908, visible: true, initialSequence: "Interaction_Lapentafoothold_A01_Off");
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 931) >= 4) {
                    return new State감지(context);
                }

                if (context.UserDetected(boxIds: new []{931})) {
                    return new State감지(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State감지 : TriggerState {
            internal State감지(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{8005, 8006, 8007, 8008}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{921}, jobCode: 0) && context.UserDetected(boxIds: new []{922}, jobCode: 0) && context.UserDetected(boxIds: new []{923}, jobCode: 0) && context.UserDetected(boxIds: new []{924}, jobCode: 0)) {
                    return new StateSuccess(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSuccess : TriggerState {
            internal StateSuccess(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 99990021, key: "Reconnect", value: 2);
                context.SetEventUI(arg1: 1, script: "$02020112_BF__JUMPROOM__0$", duration: 5000);
                context.SetGravity(gravity: 0f);
                context.SetEffect(triggerIds: new []{8005, 8006, 8007, 8008}, visible: false);
                context.AddBuff(boxIds: new []{931}, skillId: 70002112, level: 1, arg5: false);
                context.SetUserValue(triggerId: 99990009, key: "ButtonSuccess", value: 1);
                context.SetUserValue(triggerId: 99990010, key: "ButtonSuccess", value: 1);
                context.SetUserValue(triggerId: 99990011, key: "ButtonSuccess", value: 1);
                context.SetUserValue(triggerId: 99990012, key: "ButtonSuccess", value: 1);
                context.SetMesh(triggerIds: new []{1501, 1502, 1503, 1504, 1505, 1506, 1507, 1508, 1509}, visible: false, arg3: 0, arg4: 20, arg5: 3f);
                context.SetMesh(triggerIds: new []{1510, 1511, 1512, 1513, 1514, 1515, 1516, 1517, 1518}, visible: false, arg3: 0, arg4: 20, arg5: 3f);
                context.SetMesh(triggerIds: new []{1519, 1520, 1521, 1522, 1523, 1524, 1525, 1526, 1527}, visible: false, arg3: 0, arg4: 20, arg5: 3f);
                context.SetMesh(triggerIds: new []{1528, 1529, 1530, 1531, 1532, 1533, 1534, 1535, 1536}, visible: false, arg3: 0, arg4: 20, arg5: 3f);
                context.SetActor(triggerId: 9905, visible: false, initialSequence: "Interaction_Lapentafoothold_A01_On");
                context.SetActor(triggerId: 9906, visible: false, initialSequence: "Interaction_Lapentafoothold_A01_On");
                context.SetActor(triggerId: 9907, visible: false, initialSequence: "Interaction_Lapentafoothold_A01_On");
                context.SetActor(triggerId: 9908, visible: false, initialSequence: "Interaction_Lapentafoothold_A01_On");
                context.CreateMonster(spawnIds: new []{152, 153, 154, 155}, arg2: false);
                context.EnableSpawnPointPc(spawnId: 0, enabled: false);
                context.EnableSpawnPointPc(spawnId: 1, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{152, 153, 154, 155})) {
                    context.SetUserValue(triggerId: 99990001, key: "MonsterDead", value: 1);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
