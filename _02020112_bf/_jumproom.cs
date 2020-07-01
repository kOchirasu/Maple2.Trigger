namespace Maple2.Trigger._02020112_bf {
    public static class _jumproom {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.EnableSpawnPointPc(spawnPointId: 1, isEnable: false);
                context.SetEffect(arg1: new[] {8005, 8006, 8007, 8008}, arg2: false);
                context.SetUserValue(triggerId: 99990009, key: "ButtonSuccess", value: 0);
                context.SetUserValue(triggerId: 99990010, key: "ButtonSuccess", value: 0);
                context.SetUserValue(triggerId: 99990011, key: "ButtonSuccess", value: 0);
                context.SetUserValue(triggerId: 99990012, key: "ButtonSuccess", value: 0);
                context.SetUserValue(triggerId: 99990001, key: "MonsterDead", value: 0);
                context.SetActor(arg1: 9905, arg2: true, arg3: "Interaction_Lapentafoothold_A01_Off");
                context.SetActor(arg1: 9906, arg2: true, arg3: "Interaction_Lapentafoothold_A01_Off");
                context.SetActor(arg1: 9907, arg2: true, arg3: "Interaction_Lapentafoothold_A01_Off");
                context.SetActor(arg1: 9908, arg2: true, arg3: "Interaction_Lapentafoothold_A01_Off");
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 931) >= 4) {
                    return new State감지(context);
                }

                if (context.UserDetected(arg1: new[] {931})) {
                    return new State감지(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State감지 : TriggerState {
            internal State감지(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8005, 8006, 8007, 8008}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {921}, arg2: 0) && context.UserDetected(arg1: new[] {922}, arg2: 0) && context.UserDetected(arg1: new[] {923}, arg2: 0) && context.UserDetected(arg1: new[] {924}, arg2: 0)) {
                    return new State성공(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State성공 : TriggerState {
            internal State성공(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 99990021, key: "Reconnect", value: 2);
                context.SetEventUI(arg1: 1, arg2: "$02020112_BF__JUMPROOM__0$", arg3: 5000);
                context.SetGravity(gravity: 0f);
                context.SetEffect(arg1: new[] {8005, 8006, 8007, 8008}, arg2: false);
                context.AddBuff(arg1: new[] {931}, arg2: 70002112, arg3: 1, arg5: false);
                context.SetUserValue(triggerId: 99990009, key: "ButtonSuccess", value: 1);
                context.SetUserValue(triggerId: 99990010, key: "ButtonSuccess", value: 1);
                context.SetUserValue(triggerId: 99990011, key: "ButtonSuccess", value: 1);
                context.SetUserValue(triggerId: 99990012, key: "ButtonSuccess", value: 1);
                context.SetMesh(arg1: new[] {1501, 1502, 1503, 1504, 1505, 1506, 1507, 1508, 1509}, arg2: false, arg3: 0, arg4: 20, arg5: 3f);
                context.SetMesh(arg1: new[] {1510, 1511, 1512, 1513, 1514, 1515, 1516, 1517, 1518}, arg2: false, arg3: 0, arg4: 20, arg5: 3f);
                context.SetMesh(arg1: new[] {1519, 1520, 1521, 1522, 1523, 1524, 1525, 1526, 1527}, arg2: false, arg3: 0, arg4: 20, arg5: 3f);
                context.SetMesh(arg1: new[] {1528, 1529, 1530, 1531, 1532, 1533, 1534, 1535, 1536}, arg2: false, arg3: 0, arg4: 20, arg5: 3f);
                context.SetActor(arg1: 9905, arg2: false, arg3: "Interaction_Lapentafoothold_A01_On");
                context.SetActor(arg1: 9906, arg2: false, arg3: "Interaction_Lapentafoothold_A01_On");
                context.SetActor(arg1: 9907, arg2: false, arg3: "Interaction_Lapentafoothold_A01_On");
                context.SetActor(arg1: 9908, arg2: false, arg3: "Interaction_Lapentafoothold_A01_On");
                context.CreateMonster(arg1: new[] {152, 153, 154, 155}, arg2: false);
                context.EnableSpawnPointPc(spawnPointId: 0, isEnable: false);
                context.EnableSpawnPointPc(spawnPointId: 1, isEnable: true);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {152, 153, 154, 155})) {
                    context.SetUserValue(triggerId: 99990001, key: "MonsterDead", value: 1);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}