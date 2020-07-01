namespace Maple2.Trigger._02020101_bf {
    public static class _main {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 4, arg2: false, arg3: false, arg4: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {1001})) {
                    context.State = new State시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveBuff(arg1: 1003, arg2: 70002151, arg3: true);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {1002})) {
                    context.State = new State보스전_시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스전_시작 : TriggerState {
            internal State보스전_시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: "talk", npcId: 23501001, illust: "Turned_Yuperia_normal", script: "$02020101_BF__MAIN__0$", duration: 5670, voice: @"ko/Npc/00002206");
                context.DungeonResetTime(seconds: 420);
                context.CreateMonster(arg1: new[] {101});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5670)) {
                    context.State = new State조건추가(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State조건추가 : TriggerState {
            internal State조건추가(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {101}) && context.GetDungeonPlayTime() < 420) {
                    context.State = new State보스전_성공(context);
                    return;
                }

                if (context.GetDungeonPlayTime() == 420) {
                    context.State = new State보스전_타임어택실패(context);
                    return;
                }

                if (context.GetUserValue(key: "SkillBreakFail") == 1) {
                    context.State = new State보스전_스킬브레이크실패(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스전_스킬브레이크실패 : TriggerState {
            internal State보스전_스킬브레이크실패(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonStopTimer();
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State보스전_리셋세팅(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스전_타임어택실패 : TriggerState {
            internal State보스전_타임어택실패(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {-1});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State보스전_타임어택실패세팅(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스전_리셋세팅 : TriggerState {
            internal State보스전_리셋세팅(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {-1});
                context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
                context.MoveUser(arg1: 2020101, arg2: 1, arg3: 1002);
                context.RemoveBuff(arg1: 1003, arg2: 70002122, arg3: true);
                context.RemoveBuff(arg1: 1003, arg2: 70002151, arg3: true);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스전_타임어택실패세팅 : TriggerState {
            internal State보스전_타임어택실패세팅(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonSetEndTime();
                context.DungeonCloseTimer();
                context.RemoveBuff(arg1: 1003, arg2: 70002151, arg3: true);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class State보스전_성공 : TriggerState {
            internal State보스전_성공(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonMissionComplete(missionId: 23038005);
                context.DungeonSetEndTime();
                context.SideNpcTalk(type: "talk", npcId: 23501001, illust: "Turned_Yuperia_normal", script: "$02020101_BF__MAIN__1$", duration: 7940, voice: @"ko/Npc/00002207");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 7940)) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {-1});
                context.DungeonClear();
                context.SetAchievement(arg2: "trigger", arg3: "ClearGreenLapenta");
                context.RemoveBuff(arg1: 1003, arg2: 70002151, arg3: true);
                context.SetPortal(arg1: 4, arg2: true, arg3: true, arg4: true);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}