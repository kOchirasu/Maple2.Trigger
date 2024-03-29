namespace Maple2.Trigger._02020140_bf {
    public static class _barricade {
        public class StateWaitStart : TriggerState {
            internal StateWaitStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserCount() > 0) {
                    return new State칸막이Wait시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State칸막이Wait시작 : TriggerState {
            internal State칸막이Wait시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{601, 602, 603, 604, 605}, visible: false);
                context.SetMesh(triggerIds: new []{608, 609}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State칸막이Wait알림(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State칸막이Wait알림 : TriggerState {
            internal State칸막이Wait알림(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$02020140_BF__BARRICADE__0$", duration: 3000);
                context.DungeonEnableGiveUp(enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.DungeonTimeOut()) {
                    return new StateDungeonFailure종료(context);
                }

                if (context.GetDungeonState() == "Fail") {
                    return new StateDungeonFailure종료(context);
                }

                if (context.WaitTick(waitTick: 30000)) {
                    return new State칸막이막기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State칸막이막기 : TriggerState {
            internal State칸막이막기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{601, 602, 603, 604, 605}, visible: true);
                context.SetMesh(triggerIds: new []{608, 609}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.DungeonTimeOut()) {
                    return new StateDungeonFailure종료(context);
                }

                if (context.GetDungeonState() == "Fail") {
                    return new StateDungeonFailure종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDungeonFailure종료 : TriggerState {
            internal StateDungeonFailure종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{601, 602, 603, 604, 605}, visible: false);
                context.SetMesh(triggerIds: new []{608, 609}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
