namespace Maple2.Trigger._52000090_qd {
    public static class _52000090_trigger {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {
                    1000, 1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008, 1009, 1010, 1011, 1012, 1013, 1014, 1015,
                    1016, 1017, 1018, 1019, 1020, 1021, 1022, 1023, 1024, 1025, 1026, 1027, 1028, 1029
                });
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {9100}, arg2: new[] {50100470},
                    arg3: new byte[] {1})) {
                    context.State = new State20002272진행중일때(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {9100}, arg2: new[] {20002272},
                    arg3: new byte[] {1})) {
                    context.State = new State20002272진행중일때(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State20002272진행중일때 : TriggerState {
            internal State20002272진행중일때(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SpawnNpcRange(
                    rangeId: new[] {1000, 1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008, 1009, 1010},
                    isAutoTargeting: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State20002272진행중일때02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State20002272진행중일때02 : TriggerState {
            internal State20002272진행중일때02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SpawnNpcRange(rangeId: new[] {1011, 1012, 1013, 1014, 1015}, isAutoTargeting: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State20002272진행중일때03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State20002272진행중일때03 : TriggerState {
            internal State20002272진행중일때03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SpawnNpcRange(rangeId: new[] {1016, 1017, 1018, 1019, 1020}, isAutoTargeting: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State20002272진행중일때04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State20002272진행중일때04 : TriggerState {
            internal State20002272진행중일때04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SpawnNpcRange(rangeId: new[] {1021, 1022, 1023, 1024, 1025, 1026, 1027, 1028, 1029},
                    isAutoTargeting: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}