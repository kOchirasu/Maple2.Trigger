namespace Maple2.Trigger._02000379_bf {
    public static class _spykandura02 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "SpyKandura", value: 0);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "SpyKandura") == 1) {
                    context.State = new StateDelay01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDelay01 : TriggerState {
            internal StateDelay01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 15000)) {
                    context.State = new StateKanduraAppRightRandom(context);
                    return;
                }

                if (context.GetUserValue(key: "SpyKandura") == 2) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateKanduraAppRightRandom : TriggerState {
            internal StateKanduraAppRightRandom(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StateKanduraAppRight01(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StateKanduraAppRight02(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StateKanduraAppRight03(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StateKanduraAppRight04(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StateKanduraAppRight05(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StateKanduraAppRight06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateKanduraAppLeftRandom : TriggerState {
            internal StateKanduraAppLeftRandom(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StateKanduraAppLeft01(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StateKanduraAppLeft02(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StateKanduraAppLeft03(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StateKanduraAppLeft04(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StateKanduraAppLeft05(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StateKanduraAppLeft06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateKanduraAppCenterRandom : TriggerState {
            internal StateKanduraAppCenterRandom(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StateKanduraAppCenter01(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StateKanduraAppCenter02(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StateKanduraAppCenter03(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StateKanduraAppCenter04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateKanduraAppRight01 : TriggerState {
            internal StateKanduraAppRight01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {430}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateKanduraDisAppRight01(context);
                    return;
                }

                if (context.GetUserValue(key: "SpyKandura") == 2) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateKanduraDisAppRight01 : TriggerState {
            internal StateKanduraDisAppRight01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {430});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateKanduraAppCenterRandom(context);
                    return;
                }

                if (context.GetUserValue(key: "SpyKandura") == 2) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateKanduraAppRight02 : TriggerState {
            internal StateKanduraAppRight02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {431}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateKanduraDisAppRight02(context);
                    return;
                }

                if (context.GetUserValue(key: "SpyKandura") == 2) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateKanduraDisAppRight02 : TriggerState {
            internal StateKanduraDisAppRight02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {431});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateKanduraAppCenterRandom(context);
                    return;
                }

                if (context.GetUserValue(key: "SpyKandura") == 2) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateKanduraAppRight03 : TriggerState {
            internal StateKanduraAppRight03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {432}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateKanduraDisAppRight03(context);
                    return;
                }

                if (context.GetUserValue(key: "SpyKandura") == 2) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateKanduraDisAppRight03 : TriggerState {
            internal StateKanduraDisAppRight03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {432});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateKanduraAppCenterRandom(context);
                    return;
                }

                if (context.GetUserValue(key: "SpyKandura") == 2) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateKanduraAppRight04 : TriggerState {
            internal StateKanduraAppRight04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {433}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateKanduraDisAppRight04(context);
                    return;
                }

                if (context.GetUserValue(key: "SpyKandura") == 2) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateKanduraDisAppRight04 : TriggerState {
            internal StateKanduraDisAppRight04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {433});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateKanduraAppCenterRandom(context);
                    return;
                }

                if (context.GetUserValue(key: "SpyKandura") == 2) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateKanduraAppRight05 : TriggerState {
            internal StateKanduraAppRight05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {434}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateKanduraDisAppRight05(context);
                    return;
                }

                if (context.GetUserValue(key: "SpyKandura") == 2) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateKanduraDisAppRight05 : TriggerState {
            internal StateKanduraDisAppRight05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {434});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateKanduraAppCenterRandom(context);
                    return;
                }

                if (context.GetUserValue(key: "SpyKandura") == 2) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateKanduraAppRight06 : TriggerState {
            internal StateKanduraAppRight06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {435}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateKanduraDisAppRight06(context);
                    return;
                }

                if (context.GetUserValue(key: "SpyKandura") == 2) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateKanduraDisAppRight06 : TriggerState {
            internal StateKanduraDisAppRight06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {435});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateKanduraAppCenterRandom(context);
                    return;
                }

                if (context.GetUserValue(key: "SpyKandura") == 2) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateKanduraAppCenter01 : TriggerState {
            internal StateKanduraAppCenter01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {420}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateKanduraDisAppCenter01(context);
                    return;
                }

                if (context.GetUserValue(key: "SpyKandura") == 2) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateKanduraDisAppCenter01 : TriggerState {
            internal StateKanduraDisAppCenter01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {420});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateKanduraAppLeftRandom(context);
                    return;
                }

                if (context.GetUserValue(key: "SpyKandura") == 2) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateKanduraAppCenter02 : TriggerState {
            internal StateKanduraAppCenter02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {421}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateKanduraDisAppCenter02(context);
                    return;
                }

                if (context.GetUserValue(key: "SpyKandura") == 2) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateKanduraDisAppCenter02 : TriggerState {
            internal StateKanduraDisAppCenter02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {421});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateKanduraAppLeftRandom(context);
                    return;
                }

                if (context.GetUserValue(key: "SpyKandura") == 2) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateKanduraAppCenter03 : TriggerState {
            internal StateKanduraAppCenter03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {422}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateKanduraDisAppCenter03(context);
                    return;
                }

                if (context.GetUserValue(key: "SpyKandura") == 2) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateKanduraDisAppCenter03 : TriggerState {
            internal StateKanduraDisAppCenter03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {422});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateKanduraAppLeftRandom(context);
                    return;
                }

                if (context.GetUserValue(key: "SpyKandura") == 2) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateKanduraAppCenter04 : TriggerState {
            internal StateKanduraAppCenter04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {423}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateKanduraDisAppCenter04(context);
                    return;
                }

                if (context.GetUserValue(key: "SpyKandura") == 2) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateKanduraDisAppCenter04 : TriggerState {
            internal StateKanduraDisAppCenter04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {423});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateKanduraAppLeftRandom(context);
                    return;
                }

                if (context.GetUserValue(key: "SpyKandura") == 2) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateKanduraAppLeft01 : TriggerState {
            internal StateKanduraAppLeft01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {410}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateKanduraDisAppLeft01(context);
                    return;
                }

                if (context.GetUserValue(key: "SpyKandura") == 2) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateKanduraDisAppLeft01 : TriggerState {
            internal StateKanduraDisAppLeft01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {410});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateKanduraAppRightRandom(context);
                    return;
                }

                if (context.GetUserValue(key: "SpyKandura") == 2) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateKanduraAppLeft02 : TriggerState {
            internal StateKanduraAppLeft02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {411}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateKanduraDisAppLeft02(context);
                    return;
                }

                if (context.GetUserValue(key: "SpyKandura") == 2) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateKanduraDisAppLeft02 : TriggerState {
            internal StateKanduraDisAppLeft02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {411});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateKanduraAppRightRandom(context);
                    return;
                }

                if (context.GetUserValue(key: "SpyKandura") == 2) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateKanduraAppLeft03 : TriggerState {
            internal StateKanduraAppLeft03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {412}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateKanduraDisAppLeft03(context);
                    return;
                }

                if (context.GetUserValue(key: "SpyKandura") == 2) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateKanduraDisAppLeft03 : TriggerState {
            internal StateKanduraDisAppLeft03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {412});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateKanduraAppRightRandom(context);
                    return;
                }

                if (context.GetUserValue(key: "SpyKandura") == 2) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateKanduraAppLeft04 : TriggerState {
            internal StateKanduraAppLeft04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {413}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateKanduraDisAppLeft04(context);
                    return;
                }

                if (context.GetUserValue(key: "SpyKandura") == 2) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateKanduraDisAppLeft04 : TriggerState {
            internal StateKanduraDisAppLeft04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {413});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateKanduraAppRightRandom(context);
                    return;
                }

                if (context.GetUserValue(key: "SpyKandura") == 2) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateKanduraAppLeft05 : TriggerState {
            internal StateKanduraAppLeft05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {414}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateKanduraDisAppLeft05(context);
                    return;
                }

                if (context.GetUserValue(key: "SpyKandura") == 2) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateKanduraDisAppLeft05 : TriggerState {
            internal StateKanduraDisAppLeft05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {414});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateKanduraAppRightRandom(context);
                    return;
                }

                if (context.GetUserValue(key: "SpyKandura") == 2) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateKanduraAppLeft06 : TriggerState {
            internal StateKanduraAppLeft06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {415}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateKanduraDisAppLeft06(context);
                    return;
                }

                if (context.GetUserValue(key: "SpyKandura") == 2) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateKanduraDisAppLeft06 : TriggerState {
            internal StateKanduraDisAppLeft06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {415});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateKanduraAppRightRandom(context);
                    return;
                }

                if (context.GetUserValue(key: "SpyKandura") == 2) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {410, 411, 412, 413, 414, 415, 420, 421, 422, 423, 430, 431, 432, 433, 434, 435});
                context.SetUserValue(key: "SpyKandura", value: 0);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}