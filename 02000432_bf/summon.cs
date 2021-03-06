namespace Maple2.Trigger._02000432_bf {
    public static class _summon {
        public class StateRoomCheck : TriggerState {
            internal StateRoomCheck(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.IsDungeonRoom()) {
                    return new State소환(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State소환 : TriggerState {
            internal State소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip(state: new State죽음Wait(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State죽음Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State죽음Wait : TriggerState {
            internal State죽음Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip();
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    return new State셀린Dead(context);
                }

                if (context.MonsterDead(arg1: new[] {2002})) {
                    return new State피리스Dead(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State셀린Dead : TriggerState {
            internal State셀린Dead(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 2002, script: "$02000432_BF__SUMMON__1$", arg4: 4, arg5: 0);
                context.AddBuff(arg1: new[] {2002}, arg2: 40500011, arg3: 1, arg4: true, arg5: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2002})) {
                    context.SetAchievement(arg1: 199, arg2: "trigger", arg3: "SirenDualKill");
                    return new StateEnd(context);
                }

                if (context.WaitTick(waitTick: 2000)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State피리스Dead : TriggerState {
            internal State피리스Dead(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {603}, arg2: true);
                context.SetAchievement(arg1: 199, arg2: "trigger", arg3: "BigSisterFirst");
                context.SetConversation(arg1: 1, arg2: 2001, script: "$02000432_BF__SUMMON__0$", arg4: 4, arg5: 0);
                context.AddBuff(arg1: new[] {2001}, arg2: 40500011, arg3: 1, arg4: true, arg5: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    context.SetAchievement(arg1: 199, arg2: "trigger", arg3: "SirenDualKill");
                    return new StateEnd(context);
                }

                if (context.WaitTick(waitTick: 2000)) {
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