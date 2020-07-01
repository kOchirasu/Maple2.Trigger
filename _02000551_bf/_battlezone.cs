namespace Maple2.Trigger._02000551_bf {
    public static class _battlezone {
        public class State시작대기중 : TriggerState {
            internal State시작대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserCount() > 0) {
                    return new State트리거작동시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State트리거작동시작 : TriggerState {
            internal State트리거작동시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 13, arg2: new[] {101})) {
                    return new State중앙전투판신호(context);
                }

                if (context.NpcDetected(arg1: 12, arg2: new[] {101})) {
                    return new State12시전투판신호(context);
                }

                if (context.NpcDetected(arg1: 3, arg2: new[] {101})) {
                    return new State3시전투판신호(context);
                }

                if (context.NpcDetected(arg1: 6, arg2: new[] {101})) {
                    return new State6시전투판신호(context);
                }

                if (context.NpcDetected(arg1: 9, arg2: new[] {101})) {
                    return new State9시전투판신호(context);
                }

                if (context.NpcDetected(arg1: 122, arg2: new[] {101})) {
                    return new State봄컨셉도로신호(context);
                }

                if (context.NpcDetected(arg1: 45, arg2: new[] {101})) {
                    return new State여름컨셉도로신호(context);
                }

                if (context.NpcDetected(arg1: 78, arg2: new[] {101})) {
                    return new State가을컨셉도로신호(context);
                }

                if (context.NpcDetected(arg1: 1011, arg2: new[] {101})) {
                    return new State겨울컨셉도로신호(context);
                }

                if (context.NpcDetected(arg1: 13, arg2: new[] {102})) {
                    return new State중앙전투판신호(context);
                }

                if (context.NpcDetected(arg1: 12, arg2: new[] {102})) {
                    return new State12시전투판신호(context);
                }

                if (context.NpcDetected(arg1: 3, arg2: new[] {102})) {
                    return new State3시전투판신호(context);
                }

                if (context.NpcDetected(arg1: 6, arg2: new[] {102})) {
                    return new State6시전투판신호(context);
                }

                if (context.NpcDetected(arg1: 9, arg2: new[] {102})) {
                    return new State9시전투판신호(context);
                }

                if (context.NpcDetected(arg1: 122, arg2: new[] {102})) {
                    return new State봄컨셉도로신호(context);
                }

                if (context.NpcDetected(arg1: 45, arg2: new[] {102})) {
                    return new State여름컨셉도로신호(context);
                }

                if (context.NpcDetected(arg1: 78, arg2: new[] {102})) {
                    return new State가을컨셉도로신호(context);
                }

                if (context.NpcDetected(arg1: 1011, arg2: new[] {102})) {
                    return new State겨울컨셉도로신호(context);
                }

                if (context.WaitTick(waitTick: 2200)) {
                    return new State시간경과대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State시간경과대기 : TriggerState {
            internal State시간경과대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State트리거작동시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State중앙전투판신호 : TriggerState {
            internal State중앙전투판신호(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAiExtraData(key: "BattleZonePosition", value: 13);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State트리거작동시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State12시전투판신호 : TriggerState {
            internal State12시전투판신호(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAiExtraData(key: "BattleZonePosition", value: 12);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State트리거작동시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3시전투판신호 : TriggerState {
            internal State3시전투판신호(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAiExtraData(key: "BattleZonePosition", value: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State트리거작동시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State6시전투판신호 : TriggerState {
            internal State6시전투판신호(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAiExtraData(key: "BattleZonePosition", value: 6);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State트리거작동시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State9시전투판신호 : TriggerState {
            internal State9시전투판신호(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAiExtraData(key: "BattleZonePosition", value: 9);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State트리거작동시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State봄컨셉도로신호 : TriggerState {
            internal State봄컨셉도로신호(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAiExtraData(key: "BattleZonePosition", value: 122);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State트리거작동시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State여름컨셉도로신호 : TriggerState {
            internal State여름컨셉도로신호(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAiExtraData(key: "BattleZonePosition", value: 45);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State트리거작동시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State가을컨셉도로신호 : TriggerState {
            internal State가을컨셉도로신호(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAiExtraData(key: "BattleZonePosition", value: 78);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State트리거작동시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State겨울컨셉도로신호 : TriggerState {
            internal State겨울컨셉도로신호(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAiExtraData(key: "BattleZonePosition", value: 1011);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State트리거작동시작(context);
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