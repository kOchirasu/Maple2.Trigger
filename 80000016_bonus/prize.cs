namespace Maple2.Trigger._80000016_bonus {
    public static class _prize {
        public class State입장 : TriggerState {
            internal State입장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154}, arg2: true);
                context.CreateMonster(arg1: new[] {199}, arg2: false);
                context.SetPortal(portalId: 1, visible: false, enabled: false, minimapVisible: false);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {301})) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateItem(arg1: new[] {201});
                context.CreateItem(arg1: new[] {202});
                context.CreateItem(arg1: new[] {203});
                context.CreateItem(arg1: new[] {204});
                context.CreateItem(arg1: new[] {205});
                context.CreateItem(arg1: new[] {206});
                context.CreateItem(arg1: new[] {207});
                context.CreateItem(arg1: new[] {208});
                context.CreateItem(arg1: new[] {209});
                context.CreateItem(arg1: new[] {210});
                context.CreateItem(arg1: new[] {211});
                context.CreateItem(arg1: new[] {212});
                context.CreateItem(arg1: new[] {213});
                context.CreateItem(arg1: new[] {216});
                context.CreateItem(arg1: new[] {217});
                context.CreateItem(arg1: new[] {218});
                context.CreateItem(arg1: new[] {219});
                context.CreateItem(arg1: new[] {220});
                context.CreateItem(arg1: new[] {221});
                context.CreateItem(arg1: new[] {222});
                context.CreateItem(arg1: new[] {226});
                context.CreateItem(arg1: new[] {227});
                context.CreateItem(arg1: new[] {228});
                context.CreateItem(arg1: new[] {229});
                context.CreateItem(arg1: new[] {230});
                context.CreateItem(arg1: new[] {231});
                context.CreateItem(arg1: new[] {232});
                context.CreateItem(arg1: new[] {233});
                context.CreateItem(arg1: new[] {234});
                context.CreateItem(arg1: new[] {235});
                context.CreateItem(arg1: new[] {243});
                context.CreateItem(arg1: new[] {244});
                context.CreateItem(arg1: new[] {245});
                context.CreateItem(arg1: new[] {246});
                context.CreateItem(arg1: new[] {247});
                context.CreateItem(arg1: new[] {248});
                context.CreateItem(arg1: new[] {250});
                context.CreateItem(arg1: new[] {251});
                context.CreateItem(arg1: new[] {255});
                context.CreateItem(arg1: new[] {256});
                context.CreateItem(arg1: new[] {257});
                context.CreateItem(arg1: new[] {258});
                context.CreateItem(arg1: new[] {259});
                context.CreateItem(arg1: new[] {260});
                context.CreateItem(arg1: new[] {261});
                context.CreateItem(arg1: new[] {262});
                context.CreateItem(arg1: new[] {263});
                context.CreateItem(arg1: new[] {264});
                context.CreateItem(arg1: new[] {265});
                context.CreateItem(arg1: new[] {266});
                context.CreateItem(arg1: new[] {267});
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateMonster체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonster체크 : TriggerState {
            internal StateMonster체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {199})) {
                    return new StatePortalCreation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePortalCreation : TriggerState {
            internal StatePortalCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 1, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State완료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State완료 : TriggerState {
            internal State완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}