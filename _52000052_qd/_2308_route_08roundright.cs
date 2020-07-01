namespace Maple2.Trigger._52000052_qd {
    public static class _2308_route_08roundright {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(arg1: new[] {28081, 28082, 28083, 28084}, arg2: true);
                context.SetMesh(arg1: new[] {230800, 230801, 230802, 230803, 230804, 230805, 230806, 230807, 230808, 230809, 230810, 230811, 230812, 230813, 230814, 230815, 230816, 230817, 230818, 230819, 230820, 230821, 430800, 430801, 430802, 430803, 430804, 430805, 430806, 430807, 430808, 430809, 430810, 430811, 430812, 430813, 430814, 430815, 430816, 430817, 430818, 430819, 430820, 430821}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetUserValue(key: "RouteSelected", value: 0);
                context.SetUserValue(key: "MakeTrue", value: 0);
                context.SetUserValue(key: "MakeFalse", value: 0);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "RouteSelected") == 1) {
                    context.State = new StateStartDazzlingRandom01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateStartDazzlingRandom01 : TriggerState {
            internal StateStartDazzlingRandom01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetRandomMesh(arg1: new[] {230800, 230801, 230802, 230803, 230804, 230805, 230806, 230807, 230808, 230809, 230810, 230811, 230812, 230813, 230814, 230815, 230816, 230817, 230818, 230819, 230820, 230821}, arg2: true, arg3: 7, arg4: 100, arg5: 500);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new StateStartDazzlingRandom02(context);
                    return;
                }

                if (context.GetUserValue(key: "MakeTrue") == 1) {
                    context.State = new StateMakeTrue(context);
                    return;
                }

                if (context.GetUserValue(key: "MakeFalse") == 1) {
                    context.State = new StateMakeFalse(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetRandomMesh(arg1: new[] {230800, 230801, 230802, 230803, 230804, 230805, 230806, 230807, 230808, 230809, 230810, 230811, 230812, 230813, 230814, 230815, 230816, 230817, 230818, 230819, 230820, 230821}, arg2: false, arg3: 22, arg4: 0, arg5: 0);
            }
        }

        private class StateStartDazzlingRandom02 : TriggerState {
            internal StateStartDazzlingRandom02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetRandomMesh(arg1: new[] {230800, 230801, 230802, 230803, 230804, 230805, 230806, 230807, 230808, 230809, 230810, 230811, 230812, 230813, 230814, 230815, 230816, 230817, 230818, 230819, 230820, 230821}, arg2: true, arg3: 7, arg4: 100, arg5: 500);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new StateStartDazzlingRandom01(context);
                    return;
                }

                if (context.GetUserValue(key: "MakeTrue") == 1) {
                    context.State = new StateMakeTrue(context);
                    return;
                }

                if (context.GetUserValue(key: "MakeFalse") == 1) {
                    context.State = new StateMakeFalse(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetRandomMesh(arg1: new[] {230800, 230801, 230802, 230803, 230804, 230805, 230806, 230807, 230808, 230809, 230810, 230811, 230812, 230813, 230814, 230815, 230816, 230817, 230818, 230819, 230820, 230821}, arg2: false, arg3: 22, arg4: 0, arg5: 0);
            }
        }

        private class StateMakeTrue : TriggerState {
            internal StateMakeTrue(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5008}, arg2: true);
                context.SetMesh(arg1: new[] {230800, 230801, 230802, 230803, 230804, 230805, 230806, 230807, 230808, 230809, 230810, 230811, 230812, 230813, 230814, 230815, 230816, 230817, 230818, 230819, 230820, 230821}, arg2: false, arg3: 0, arg4: 0, arg5: 5f);
                context.SetRandomMesh(arg1: new[] {430800, 430801, 430802, 430803, 430804, 430805, 430806, 430807, 430808, 430809, 430810, 430811, 430812, 430813, 430814, 430815, 430816, 430817, 430818, 430819, 430820, 430821}, arg2: true, arg3: 22, arg4: 0, arg5: 50);
                context.SetAgent(arg1: new[] {28081, 28082, 28083, 28084}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMakeFalse : TriggerState {
            internal StateMakeFalse(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {230800, 230801, 230802, 230803, 230804, 230805, 230806, 230807, 230808, 230809, 230810, 230811, 230812, 230813, 230814, 230815, 230816, 230817, 230818, 230819, 230820, 230821}, arg2: false, arg3: 0, arg4: 0, arg5: 5f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}