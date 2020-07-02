namespace Maple2.Trigger._02020101_bf {
    public static class _main {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 4, arg2: false, arg3: false, arg4: false);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {1001})) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveBuff(arg1: 1003, arg2: 70002151, arg3: true);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {1002})) {
                    return new StateBoss_시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoss_시작 : TriggerState {
            internal StateBoss_시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: "talk", npcId: 23501001, illust: "Turned_Yuperia_normal", script: "$02020101_BF__MAIN__0$", duration: 5670, voice: @"ko/Npc/00002206");
                context.DungeonResetTime(seconds: 420);
                context.CreateMonster(arg1: new[] {101});
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5670)) {
                    return new State조건추가(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State조건추가 : TriggerState {
            internal State조건추가(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {101}) && context.GetDungeonPlayTime() < 420) {
                    return new StateBoss_Success(context);
                }

                if (context.GetDungeonPlayTime() == 420) {
                    return new StateBoss_타임어택실패(context);
                }

                if (context.GetUserValue(key: "SkillBreakFail") == 1) {
                    return new StateBoss_스킬브레이크실패(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoss_스킬브레이크실패 : TriggerState {
            internal StateBoss_스킬브레이크실패(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonStopTimer();
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateBoss_리셋세팅(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoss_타임어택실패 : TriggerState {
            internal StateBoss_타임어택실패(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {-1});
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateBoss_타임어택실패세팅(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoss_리셋세팅 : TriggerState {
            internal StateBoss_리셋세팅(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {-1});
                context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
                context.MoveUser(arg1: 2020101, arg2: 1, arg3: 1002);
                context.RemoveBuff(arg1: 1003, arg2: 70002122, arg3: true);
                context.RemoveBuff(arg1: 1003, arg2: 70002151, arg3: true);
            }

            public override TriggerState Execute() {
                return new StateWait(context);
            }

            public override void OnExit() { }
        }

        private class StateBoss_타임어택실패세팅 : TriggerState {
            internal StateBoss_타임어택실패세팅(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonSetEndTime();
                context.DungeonCloseTimer();
                context.RemoveBuff(arg1: 1003, arg2: 70002151, arg3: true);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoss_Success : TriggerState {
            internal StateBoss_Success(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonMissionComplete(missionId: 23038005);
                context.DungeonSetEndTime();
                context.SideNpcTalk(type: "talk", npcId: 23501001, illust: "Turned_Yuperia_normal", script: "$02020101_BF__MAIN__1$", duration: 7940, voice: @"ko/Npc/00002207");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 7940)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {-1});
                context.DungeonClear();
                context.SetAchievement(arg2: "trigger", arg3: "ClearGreenLapenta");
                context.RemoveBuff(arg1: 1003, arg2: 70002151, arg3: true);
                context.SetPortal(arg1: 4, arg2: true, arg3: true, arg4: true);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}