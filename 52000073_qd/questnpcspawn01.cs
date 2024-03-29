namespace Maple2.Trigger._52000073_qd {
    public static class _questnpcspawn01 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{101}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9900}, questIds: new []{40002667}, questStates: new byte[]{3})) {
                    return new StateNpcRemove01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9900}, questIds: new []{40002667}, questStates: new byte[]{2})) {
                    return new StateNpcChange01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9900}, questIds: new []{40002667}, questStates: new byte[]{1})) {
                    return new StateNpcChange01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9900}, questIds: new []{40002666}, questStates: new byte[]{3})) {
                    return new StateNpcChange01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9900}, questIds: new []{40002666}, questStates: new byte[]{2})) {
                    return new StateNpcChange01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9900}, questIds: new []{40002666}, questStates: new byte[]{1})) {
                    return new StateNpcChange01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9900}, questIds: new []{40002665}, questStates: new byte[]{3})) {
                    return new StateNpcChange01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9900}, questIds: new []{40002665}, questStates: new byte[]{2})) {
                    return new StateNpcChange01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9900}, questIds: new []{40002665}, questStates: new byte[]{1})) {
                    return new StateNpcChange01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9900}, questIds: new []{40002664}, questStates: new byte[]{3})) {
                    return new StateNpcChange01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9900}, questIds: new []{40002664}, questStates: new byte[]{2})) {
                    return new StateNpcChange01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9900}, questIds: new []{40002664}, questStates: new byte[]{1})) {
                    return new StateNpcChange01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9900}, questIds: new []{40002663}, questStates: new byte[]{3})) {
                    return new StateNpcChange01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9900}, questIds: new []{40002663}, questStates: new byte[]{2})) {
                    return new StateNpcChange01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9900}, questIds: new []{40002663}, questStates: new byte[]{1})) {
                    return new StateNpcChange01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9900}, questIds: new []{40002662}, questStates: new byte[]{3})) {
                    return new StateNpcChange01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9900}, questIds: new []{40002662}, questStates: new byte[]{2})) {
                    return new StateNpcChange01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9900}, questIds: new []{40002662}, questStates: new byte[]{1})) {
                    return new StateNpcChange01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNpcChange01 : TriggerState {
            internal StateNpcChange01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{101});
                context.CreateMonster(spawnIds: new []{201}, arg2: false);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class StateNpcRemove01 : TriggerState {
            internal StateNpcRemove01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{101});
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
