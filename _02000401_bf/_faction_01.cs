namespace Maple2.Trigger._02000401_bf {
    public static class _faction_01 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveBuff(arg1: 199, arg2: 99910150);
                context.SetInteractObject(arg1: new[] {12000021, 12000022, 12000037}, arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "faction01") == 1) {
                    return new State석궁준비(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State석궁준비 : TriggerState {
            internal State석궁준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 1001, arg3: "$02000401_BF__FACTION_01__0$", arg4: 5, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 1001, arg3: "$02000401_BF__FACTION_01__1$", arg4: 5, arg5: 5);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State룸체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State룸체크 : TriggerState {
            internal State룸체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.IsDungeonRoom()) {
                    return new State던전(context);
                }

                if (!context.IsDungeonRoom()) {
                    return new State퀘스트(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State던전 : TriggerState {
            internal State던전(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20040101, textId: 20040101, duration: 3500);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.SetInteractObject(arg1: new[] {12000021, 12000022}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new State종료체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State퀘스트 : TriggerState {
            internal State퀘스트(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20040101, textId: 20040101, duration: 3500);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.SetInteractObject(arg1: new[] {12000037}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new State종료체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State종료체크 : TriggerState {
            internal State종료체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2901})) {
                    context.SetInteractObject(arg1: new[] {12000021, 12000022, 12000037}, arg2: 0);
                    context.SetConversation(arg1: 1, arg2: 1001, arg3: "$02000401_BF__FACTION_01__2$", arg4: 5, arg5: 0);
                    context.RemoveBuff(arg1: 199, arg2: 99910150);
                    return new StateNPC삭제대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPC삭제대기 : TriggerState {
            internal StateNPC삭제대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "DungeonClear") == 1) {
                    context.DestroyMonster(arg1: new[] {1001, 1002, 1003, 1004, 1005}, arg2: false);
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}