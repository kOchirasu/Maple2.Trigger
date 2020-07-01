namespace Maple2.Trigger._02020120_bf {
    public static class _bossspawn {
        public class State시작대기중 : TriggerState {
            internal State시작대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {1920, 1921, 1922, 1923, 1924, 1925, 1926, 1927, 1928, 1929, 1930, 1931, 1932, 1933, 1934, 1935, 1936, 1937}, arg2: false);
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
                context.SetUserValue(key: "DungeonReset", value: 0);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {199})) {
                    return new State보스등장(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보스등장 : TriggerState {
            internal State보스등장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonResetTime(seconds: 720);
                context.SideNpcTalk(type: "talk", npcId: 23000113, illust: "Ishura_Dark_Idle", script: "$02020120_BF__BOSSSPAWN__0$", duration: 4000, voice: @"ko/Npc/00002192");
                context.CreateMonster(arg1: new[] {99}, arg2: false);
                context.SetPortal(arg1: 9901, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 9902, arg2: false, arg3: false, arg4: false);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "DungeonReset") == 1) {
                    return new State던전초기화진행(context);
                }

                if (context.MonsterDead(arg1: new[] {99})) {
                    return new State종료딜레이(context);
                }

                if (context.DungeonTimeOut()) {
                    return new State던전실패(context);
                }

                if (context.GetDungeonState() == "Fail") {
                    return new State던전실패(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State던전초기화진행 : TriggerState {
            internal State던전초기화진행(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 02020120, arg2: 9903);
                context.SetSound(arg1: 19601, arg2: true);
                context.SideNpcTalk(type: "talk", npcId: 23000113, illust: "Ishura_Dark_smile", script: "$02020120_BF__BOSSSPAWN__1$", duration: 7000, voice: @"ko/Npc/00002193");
                context.DestroyMonster(arg1: new[] {-1});
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 9000)) {
                    return new State던전초기화시간등각종설정(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State던전초기화시간등각종설정 : TriggerState {
            internal State던전초기화시간등각종설정(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonStopTimer();
                context.SetUserValue(key: "DungeonReset", value: 0);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {199})) {
                    return new State보스등장(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State종료딜레이 : TriggerState {
            internal State종료딜레이(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: "talk", npcId: 23000113, illust: "Ishura_Dark_Idle", script: "$02020120_BF__BOSSSPAWN__2$", duration: 6576, voice: @"ko/Npc/00002194");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    context.SetSkill(arg1: new[] {2222, 1212}, arg2: false);
                    context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
                    context.DungeonClear();
                    context.DungeonSetEndTime();
                    context.SetAchievement(arg3: "IshuraDungeonClear");
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State던전실패 : TriggerState {
            internal State던전실패(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {-1});
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.SetSkill(arg1: new[] {2222, 1212}, arg2: false);
                    context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
                    context.DungeonFail();
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 2101, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 2201, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 2301, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 3101, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 3102, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 3103, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 3104, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 3201, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 3202, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 3203, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 3301, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 3302, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 3303, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 3304, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 3305, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 3306, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 4101, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 4102, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 4201, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 4202, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 4301, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 4302, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 5101, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 5102, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 5201, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 5202, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 5203, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 5204, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 5205, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 5206, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 5301, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 5302, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 5303, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 5304, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 5401, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 6101, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 6201, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 6301, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 6302, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 6303, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 6304, arg2: true, arg3: true, arg4: true);
                context.DungeonEnableGiveUp(isEnable: false);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}