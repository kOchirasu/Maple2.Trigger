using Maple2.Trigger.Enum;

namespace Maple2.Trigger._84000013_wd {
    public static class _84000013_moveguest {
        public class StateReset : TriggerState {
            internal StateReset(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "Weddingceremonystartsready", value: 0);
                context.SetUserValue(key: "Weddingceremonyfail", value: 0);
            }

            public override TriggerState? Execute() {
                return new StateStart(context);
            }

            public override void OnExit() { }
        }

        private class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WeddingHallState(hallState: "weddingComplete")) {
                    return new StateEnd(context);
                }

                if (context.GetUserValue(key: "Weddingceremonystartsready") == 1) {
                    context.SetUserValue(key: "Weddingceremonystartsready", value: 0);
                    return new State새로운하객있는지감지(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State새로운하객있는지감지 : TriggerState {
            internal State새로운하객있는지감지(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WeddingHallState(hallState: "weddingComplete")) {
                    return new StateEnd(context);
                }

                if (context.GetUserValue(key: "Weddingceremonyfail") == 1) {
                    context.SetUserValue(key: "Weddingceremonyfail", value: 0);
                    return new StateStart(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new State방금입장한하객은하객석으로위치이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State방금입장한하객은하객석으로위치이동 : TriggerState {
            internal State방금입장한하객은하객석으로위치이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.WeddingMoveUser(type: WeddingEntryType.Guest, mapId: 84000013, portalIds: new []{22, 23}, boxId: 701);
            }

            public override TriggerState? Execute() {
                return new State새로운하객있는지감지(context);
            }

            public override void OnExit() { }
        }

        private class State하객은버진로드밖으로위치이동 : TriggerState {
            internal State하객은버진로드밖으로위치이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.WeddingMoveUser(type: WeddingEntryType.Guest, mapId: 84000013, portalIds: new []{22, 23}, boxId: 701);
            }

            public override TriggerState? Execute() {
                return new State새로운하객있는지감지(context);
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
