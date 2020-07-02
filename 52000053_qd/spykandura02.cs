namespace Maple2.Trigger._52000053_qd {
    public static class _spykandura02 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "SpyKandura", value: 0);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "SpyKandura") == 1) {
                    return new StateDelay01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay01 : TriggerState {
            internal StateDelay01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 15000)) {
                    return new StateKanduraAppRightRandom(context);
                }

                if (context.GetUserValue(key: "SpyKandura") == 2) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateKanduraAppRightRandom : TriggerState {
            internal StateKanduraAppRightRandom(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.RandomCondition(arg1: 10f)) {
                    return new StateKanduraAppRight01(context);
                }

                if (context.RandomCondition(arg1: 10f)) {
                    return new StateKanduraAppRight02(context);
                }

                if (context.RandomCondition(arg1: 10f)) {
                    return new StateKanduraAppRight03(context);
                }

                if (context.RandomCondition(arg1: 10f)) {
                    return new StateKanduraAppRight04(context);
                }

                if (context.RandomCondition(arg1: 10f)) {
                    return new StateKanduraAppRight05(context);
                }

                if (context.RandomCondition(arg1: 10f)) {
                    return new StateKanduraAppRight06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateKanduraAppLeftRandom : TriggerState {
            internal StateKanduraAppLeftRandom(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.RandomCondition(arg1: 10f)) {
                    return new StateKanduraAppLeft01(context);
                }

                if (context.RandomCondition(arg1: 10f)) {
                    return new StateKanduraAppLeft02(context);
                }

                if (context.RandomCondition(arg1: 10f)) {
                    return new StateKanduraAppLeft03(context);
                }

                if (context.RandomCondition(arg1: 10f)) {
                    return new StateKanduraAppLeft04(context);
                }

                if (context.RandomCondition(arg1: 10f)) {
                    return new StateKanduraAppLeft05(context);
                }

                if (context.RandomCondition(arg1: 10f)) {
                    return new StateKanduraAppLeft06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateKanduraAppCenterRandom : TriggerState {
            internal StateKanduraAppCenterRandom(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.RandomCondition(arg1: 10f)) {
                    return new StateKanduraAppCenter01(context);
                }

                if (context.RandomCondition(arg1: 10f)) {
                    return new StateKanduraAppCenter02(context);
                }

                if (context.RandomCondition(arg1: 10f)) {
                    return new StateKanduraAppCenter03(context);
                }

                if (context.RandomCondition(arg1: 10f)) {
                    return new StateKanduraAppCenter04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateKanduraAppRight01 : TriggerState {
            internal StateKanduraAppRight01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {430}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateKanduraDisAppRight01(context);
                }

                if (context.GetUserValue(key: "SpyKandura") == 2) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateKanduraDisAppRight01 : TriggerState {
            internal StateKanduraDisAppRight01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {430});
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateKanduraAppCenterRandom(context);
                }

                if (context.GetUserValue(key: "SpyKandura") == 2) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateKanduraAppRight02 : TriggerState {
            internal StateKanduraAppRight02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {431}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateKanduraDisAppRight02(context);
                }

                if (context.GetUserValue(key: "SpyKandura") == 2) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateKanduraDisAppRight02 : TriggerState {
            internal StateKanduraDisAppRight02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {431});
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateKanduraAppCenterRandom(context);
                }

                if (context.GetUserValue(key: "SpyKandura") == 2) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateKanduraAppRight03 : TriggerState {
            internal StateKanduraAppRight03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {432}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateKanduraDisAppRight03(context);
                }

                if (context.GetUserValue(key: "SpyKandura") == 2) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateKanduraDisAppRight03 : TriggerState {
            internal StateKanduraDisAppRight03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {432});
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateKanduraAppCenterRandom(context);
                }

                if (context.GetUserValue(key: "SpyKandura") == 2) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateKanduraAppRight04 : TriggerState {
            internal StateKanduraAppRight04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {433}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateKanduraDisAppRight04(context);
                }

                if (context.GetUserValue(key: "SpyKandura") == 2) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateKanduraDisAppRight04 : TriggerState {
            internal StateKanduraDisAppRight04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {433});
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateKanduraAppCenterRandom(context);
                }

                if (context.GetUserValue(key: "SpyKandura") == 2) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateKanduraAppRight05 : TriggerState {
            internal StateKanduraAppRight05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {434}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateKanduraDisAppRight05(context);
                }

                if (context.GetUserValue(key: "SpyKandura") == 2) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateKanduraDisAppRight05 : TriggerState {
            internal StateKanduraDisAppRight05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {434});
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateKanduraAppCenterRandom(context);
                }

                if (context.GetUserValue(key: "SpyKandura") == 2) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateKanduraAppRight06 : TriggerState {
            internal StateKanduraAppRight06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {435}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateKanduraDisAppRight06(context);
                }

                if (context.GetUserValue(key: "SpyKandura") == 2) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateKanduraDisAppRight06 : TriggerState {
            internal StateKanduraDisAppRight06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {435});
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateKanduraAppCenterRandom(context);
                }

                if (context.GetUserValue(key: "SpyKandura") == 2) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateKanduraAppCenter01 : TriggerState {
            internal StateKanduraAppCenter01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {420}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateKanduraDisAppCenter01(context);
                }

                if (context.GetUserValue(key: "SpyKandura") == 2) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateKanduraDisAppCenter01 : TriggerState {
            internal StateKanduraDisAppCenter01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {420});
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateKanduraAppLeftRandom(context);
                }

                if (context.GetUserValue(key: "SpyKandura") == 2) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateKanduraAppCenter02 : TriggerState {
            internal StateKanduraAppCenter02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {421}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateKanduraDisAppCenter02(context);
                }

                if (context.GetUserValue(key: "SpyKandura") == 2) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateKanduraDisAppCenter02 : TriggerState {
            internal StateKanduraDisAppCenter02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {421});
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateKanduraAppLeftRandom(context);
                }

                if (context.GetUserValue(key: "SpyKandura") == 2) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateKanduraAppCenter03 : TriggerState {
            internal StateKanduraAppCenter03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {422}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateKanduraDisAppCenter03(context);
                }

                if (context.GetUserValue(key: "SpyKandura") == 2) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateKanduraDisAppCenter03 : TriggerState {
            internal StateKanduraDisAppCenter03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {422});
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateKanduraAppLeftRandom(context);
                }

                if (context.GetUserValue(key: "SpyKandura") == 2) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateKanduraAppCenter04 : TriggerState {
            internal StateKanduraAppCenter04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {423}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateKanduraDisAppCenter04(context);
                }

                if (context.GetUserValue(key: "SpyKandura") == 2) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateKanduraDisAppCenter04 : TriggerState {
            internal StateKanduraDisAppCenter04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {423});
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateKanduraAppLeftRandom(context);
                }

                if (context.GetUserValue(key: "SpyKandura") == 2) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateKanduraAppLeft01 : TriggerState {
            internal StateKanduraAppLeft01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {410}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateKanduraDisAppLeft01(context);
                }

                if (context.GetUserValue(key: "SpyKandura") == 2) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateKanduraDisAppLeft01 : TriggerState {
            internal StateKanduraDisAppLeft01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {410});
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateKanduraAppRightRandom(context);
                }

                if (context.GetUserValue(key: "SpyKandura") == 2) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateKanduraAppLeft02 : TriggerState {
            internal StateKanduraAppLeft02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {411}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateKanduraDisAppLeft02(context);
                }

                if (context.GetUserValue(key: "SpyKandura") == 2) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateKanduraDisAppLeft02 : TriggerState {
            internal StateKanduraDisAppLeft02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {411});
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateKanduraAppRightRandom(context);
                }

                if (context.GetUserValue(key: "SpyKandura") == 2) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateKanduraAppLeft03 : TriggerState {
            internal StateKanduraAppLeft03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {412}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateKanduraDisAppLeft03(context);
                }

                if (context.GetUserValue(key: "SpyKandura") == 2) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateKanduraDisAppLeft03 : TriggerState {
            internal StateKanduraDisAppLeft03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {412});
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateKanduraAppRightRandom(context);
                }

                if (context.GetUserValue(key: "SpyKandura") == 2) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateKanduraAppLeft04 : TriggerState {
            internal StateKanduraAppLeft04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {413}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateKanduraDisAppLeft04(context);
                }

                if (context.GetUserValue(key: "SpyKandura") == 2) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateKanduraDisAppLeft04 : TriggerState {
            internal StateKanduraDisAppLeft04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {413});
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateKanduraAppRightRandom(context);
                }

                if (context.GetUserValue(key: "SpyKandura") == 2) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateKanduraAppLeft05 : TriggerState {
            internal StateKanduraAppLeft05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {414}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateKanduraDisAppLeft05(context);
                }

                if (context.GetUserValue(key: "SpyKandura") == 2) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateKanduraDisAppLeft05 : TriggerState {
            internal StateKanduraDisAppLeft05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {414});
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateKanduraAppRightRandom(context);
                }

                if (context.GetUserValue(key: "SpyKandura") == 2) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateKanduraAppLeft06 : TriggerState {
            internal StateKanduraAppLeft06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {415}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateKanduraDisAppLeft06(context);
                }

                if (context.GetUserValue(key: "SpyKandura") == 2) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateKanduraDisAppLeft06 : TriggerState {
            internal StateKanduraDisAppLeft06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {415});
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateKanduraAppRightRandom(context);
                }

                if (context.GetUserValue(key: "SpyKandura") == 2) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {410, 411, 412, 413, 414, 415, 420, 421, 422, 423, 430, 431, 432, 433, 434, 435});
                context.SetUserValue(key: "SpyKandura", value: 0);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}