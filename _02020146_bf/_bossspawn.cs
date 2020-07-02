namespace Maple2.Trigger._02020146_bf {
    public static class _bossspawn {
        public class StateWaitStart : TriggerState {
            internal StateWaitStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserCount() > 0) {
                    return new State기본Setting(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State기본Setting : TriggerState {
            internal State기본Setting(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 1, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 601, arg2: false, arg3: false, arg4: false);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {199})) {
                    return new StateBossSpawn이벤트대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBossSpawn이벤트대기 : TriggerState {
            internal StateBossSpawn이벤트대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {99}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State연출대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State연출대기 : TriggerState {
            internal State연출대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: "talk", npcId: 23000113, illust: "Ishura_Dark_Idle", script: "$02020120_BF__BOSSSPAWN__0$", duration: 4000, voice: @"ko/Npc/00002192");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State전투진행(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투진행 : TriggerState {
            internal State전투진행(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 601, arg2: true, arg3: true, arg4: true);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {99})) {
                    return new StateEndDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEndDelay : TriggerState {
            internal StateEndDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg3: "IshuraDungeonClear_Quest");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new State마무리연출(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마무리연출 : TriggerState {
            internal State마무리연출(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: "talk", npcId: 23000113, illust: "Ishura_Dark_Idle", script: "$02020120_BF__BOSSSPAWN__2$", duration: 6576, voice: @"ko/Npc/00002194");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 9000)) {
                    context.SetPortal(arg1: 1, arg2: true, arg3: true, arg4: true);
                    context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}