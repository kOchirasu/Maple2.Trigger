namespace Maple2.Trigger._02020003_bf {
    public static class _115_melodypattern {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "PatternPick", value: 0);
                context.SetUserValue(key: "Reset", value: 0);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "PatternPick") == 1) {
                    return new StateMelodyPlay01_Start(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetUserValue(key: "Reset", value: 0);
            }
        }

        private class StateMelodyPlay01_Start : TriggerState {
            internal StateMelodyPlay01_Start(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {11205}, arg2: true);
                context.SetActor(arg1: 11005, arg2: true, arg3: "ks_quest_musical_B01_blue");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateMelodyPlay01_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMelodyPlay01_End : TriggerState {
            internal StateMelodyPlay01_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 11005, arg2: true, arg3: "ks_quest_musical_B01_off");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateMelodyPlay02_Start(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMelodyPlay02_Start : TriggerState {
            internal StateMelodyPlay02_Start(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {11203}, arg2: true);
                context.SetActor(arg1: 11003, arg2: true, arg3: "ks_quest_musical_B01_yellow");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateMelodyPlay02_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMelodyPlay02_End : TriggerState {
            internal StateMelodyPlay02_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 11003, arg2: true, arg3: "ks_quest_musical_B01_off");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateMelodyPlay03_Start(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMelodyPlay03_Start : TriggerState {
            internal StateMelodyPlay03_Start(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {11206}, arg2: true);
                context.SetActor(arg1: 11006, arg2: true, arg3: "ks_quest_musical_B01_navy");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateMelodyPlay03_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMelodyPlay03_End : TriggerState {
            internal StateMelodyPlay03_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 11006, arg2: true, arg3: "ks_quest_musical_B01_off");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateMelodyPlay04_Start(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMelodyPlay04_Start : TriggerState {
            internal StateMelodyPlay04_Start(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {11204}, arg2: true);
                context.SetActor(arg1: 11004, arg2: true, arg3: "ks_quest_musical_B01_green");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateMelodyPlay04_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMelodyPlay04_End : TriggerState {
            internal StateMelodyPlay04_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 11004, arg2: true, arg3: "ks_quest_musical_B01_off");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateMelodyPlay05_Start(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMelodyPlay05_Start : TriggerState {
            internal StateMelodyPlay05_Start(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {11203}, arg2: true);
                context.SetActor(arg1: 11003, arg2: true, arg3: "ks_quest_musical_B01_yellow");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateMelodyPlay05_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMelodyPlay05_End : TriggerState {
            internal StateMelodyPlay05_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 11003, arg2: true, arg3: "ks_quest_musical_B01_off");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateCheckAnswer01_Start(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckAnswer01_Start : TriggerState {
            internal StateCheckAnswer01_Start(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 11101, arg2: false, arg3: "ks_quest_musical_A01_off");
                context.SetActor(arg1: 11102, arg2: false, arg3: "ks_quest_musical_A01_off");
                context.SetActor(arg1: 11103, arg2: false, arg3: "ks_quest_musical_A01_off");
                context.SetActor(arg1: 11104, arg2: false, arg3: "ks_quest_musical_A01_off");
                context.SetActor(arg1: 11105, arg2: false, arg3: "ks_quest_musical_A01_off");
                context.SetActor(arg1: 11106, arg2: false, arg3: "ks_quest_musical_A01_off");
                context.SetActor(arg1: 11107, arg2: false, arg3: "ks_quest_musical_A01_off");
                context.SetActor(arg1: 11108, arg2: false, arg3: "ks_quest_musical_A01_off");
                context.SetInteractObject(arg1: new[] {12000058, 12000059, 12000060, 12000061, 12000062, 12000063, 12000064, 12000065}, arg2: 1);
                context.SetUserValue(triggerId: 11001, key: "PlayC", value: 1);
                context.SetUserValue(triggerId: 11002, key: "PlayD", value: 1);
                context.SetUserValue(triggerId: 11003, key: "PlayE", value: 1);
                context.SetUserValue(triggerId: 11004, key: "PlayF", value: 1);
                context.SetUserValue(triggerId: 11005, key: "PlayG", value: 1);
                context.SetUserValue(triggerId: 11006, key: "PlayA", value: 1);
                context.SetUserValue(triggerId: 11007, key: "PlayB", value: 1);
                context.SetUserValue(triggerId: 11008, key: "PlayHighC", value: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {12000058}, arg2: 0)) {
                    return new StateAnswerIsWrong_Delay(context);
                }

                if (context.ObjectInteracted(arg1: new[] {12000059}, arg2: 0)) {
                    return new StateAnswerIsWrong_Delay(context);
                }

                if (context.ObjectInteracted(arg1: new[] {12000060}, arg2: 0)) {
                    return new StateAnswerIsWrong_Delay(context);
                }

                if (context.ObjectInteracted(arg1: new[] {12000061}, arg2: 0)) {
                    return new StateAnswerIsWrong_Delay(context);
                }

                if (context.ObjectInteracted(arg1: new[] {12000062}, arg2: 0)) {
                    return new StateCheckAnswer01_Delay(context);
                }

                if (context.ObjectInteracted(arg1: new[] {12000063}, arg2: 0)) {
                    return new StateAnswerIsWrong_Delay(context);
                }

                if (context.ObjectInteracted(arg1: new[] {12000064}, arg2: 0)) {
                    return new StateAnswerIsWrong_Delay(context);
                }

                if (context.ObjectInteracted(arg1: new[] {12000065}, arg2: 0)) {
                    return new StateAnswerIsWrong_Delay(context);
                }

                if (context.GetUserValue(key: "Reset") == 1) {
                    return new StateResetDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckAnswer01_Delay : TriggerState {
            internal StateCheckAnswer01_Delay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateCheckAnswer02_Start(context);
                }

                if (context.GetUserValue(key: "Reset") == 1) {
                    return new StateResetDelay(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetInteractObject(arg1: new[] {12000062}, arg2: 1);
            }
        }

        private class StateCheckAnswer02_Start : TriggerState {
            internal StateCheckAnswer02_Start(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {12000058}, arg2: 0)) {
                    return new StateAnswerIsWrong_Delay(context);
                }

                if (context.ObjectInteracted(arg1: new[] {12000059}, arg2: 0)) {
                    return new StateAnswerIsWrong_Delay(context);
                }

                if (context.ObjectInteracted(arg1: new[] {12000060}, arg2: 0)) {
                    return new StateCheckAnswer02_Delay(context);
                }

                if (context.ObjectInteracted(arg1: new[] {12000061}, arg2: 0)) {
                    return new StateAnswerIsWrong_Delay(context);
                }

                if (context.ObjectInteracted(arg1: new[] {12000062}, arg2: 0)) {
                    return new StateAnswerIsWrong_Delay(context);
                }

                if (context.ObjectInteracted(arg1: new[] {12000063}, arg2: 0)) {
                    return new StateAnswerIsWrong_Delay(context);
                }

                if (context.ObjectInteracted(arg1: new[] {12000064}, arg2: 0)) {
                    return new StateAnswerIsWrong_Delay(context);
                }

                if (context.ObjectInteracted(arg1: new[] {12000065}, arg2: 0)) {
                    return new StateAnswerIsWrong_Delay(context);
                }

                if (context.GetUserValue(key: "Reset") == 1) {
                    return new StateResetDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckAnswer02_Delay : TriggerState {
            internal StateCheckAnswer02_Delay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateCheckAnswer03_Start(context);
                }

                if (context.GetUserValue(key: "Reset") == 1) {
                    return new StateResetDelay(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetInteractObject(arg1: new[] {12000060}, arg2: 1);
            }
        }

        private class StateCheckAnswer03_Start : TriggerState {
            internal StateCheckAnswer03_Start(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {12000058}, arg2: 0)) {
                    return new StateAnswerIsWrong_Delay(context);
                }

                if (context.ObjectInteracted(arg1: new[] {12000059}, arg2: 0)) {
                    return new StateAnswerIsWrong_Delay(context);
                }

                if (context.ObjectInteracted(arg1: new[] {12000060}, arg2: 0)) {
                    return new StateAnswerIsWrong_Delay(context);
                }

                if (context.ObjectInteracted(arg1: new[] {12000061}, arg2: 0)) {
                    return new StateAnswerIsWrong_Delay(context);
                }

                if (context.ObjectInteracted(arg1: new[] {12000062}, arg2: 0)) {
                    return new StateAnswerIsWrong_Delay(context);
                }

                if (context.ObjectInteracted(arg1: new[] {12000063}, arg2: 0)) {
                    return new StateCheckAnswer03_Delay(context);
                }

                if (context.ObjectInteracted(arg1: new[] {12000064}, arg2: 0)) {
                    return new StateAnswerIsWrong_Delay(context);
                }

                if (context.ObjectInteracted(arg1: new[] {12000065}, arg2: 0)) {
                    return new StateAnswerIsWrong_Delay(context);
                }

                if (context.GetUserValue(key: "Reset") == 1) {
                    return new StateResetDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckAnswer03_Delay : TriggerState {
            internal StateCheckAnswer03_Delay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateCheckAnswer04_Start(context);
                }

                if (context.GetUserValue(key: "Reset") == 1) {
                    return new StateResetDelay(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetInteractObject(arg1: new[] {12000063}, arg2: 1);
            }
        }

        private class StateCheckAnswer04_Start : TriggerState {
            internal StateCheckAnswer04_Start(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {12000058}, arg2: 0)) {
                    return new StateAnswerIsWrong_Delay(context);
                }

                if (context.ObjectInteracted(arg1: new[] {12000059}, arg2: 0)) {
                    return new StateAnswerIsWrong_Delay(context);
                }

                if (context.ObjectInteracted(arg1: new[] {12000060}, arg2: 0)) {
                    return new StateAnswerIsWrong_Delay(context);
                }

                if (context.ObjectInteracted(arg1: new[] {12000061}, arg2: 0)) {
                    return new StateCheckAnswer04_Delay(context);
                }

                if (context.ObjectInteracted(arg1: new[] {12000062}, arg2: 0)) {
                    return new StateAnswerIsWrong_Delay(context);
                }

                if (context.ObjectInteracted(arg1: new[] {12000063}, arg2: 0)) {
                    return new StateAnswerIsWrong_Delay(context);
                }

                if (context.ObjectInteracted(arg1: new[] {12000064}, arg2: 0)) {
                    return new StateAnswerIsWrong_Delay(context);
                }

                if (context.ObjectInteracted(arg1: new[] {12000065}, arg2: 0)) {
                    return new StateAnswerIsWrong_Delay(context);
                }

                if (context.GetUserValue(key: "Reset") == 1) {
                    return new StateResetDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckAnswer04_Delay : TriggerState {
            internal StateCheckAnswer04_Delay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateCheckAnswer05_Start(context);
                }

                if (context.GetUserValue(key: "Reset") == 1) {
                    return new StateResetDelay(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetInteractObject(arg1: new[] {12000061}, arg2: 1);
            }
        }

        private class StateCheckAnswer05_Start : TriggerState {
            internal StateCheckAnswer05_Start(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {12000058}, arg2: 0)) {
                    return new StateAnswerIsWrong_Delay(context);
                }

                if (context.ObjectInteracted(arg1: new[] {12000059}, arg2: 0)) {
                    return new StateAnswerIsWrong_Delay(context);
                }

                if (context.ObjectInteracted(arg1: new[] {12000060}, arg2: 0)) {
                    return new StateCheckAnswer05_Delay(context);
                }

                if (context.ObjectInteracted(arg1: new[] {12000061}, arg2: 0)) {
                    return new StateAnswerIsWrong_Delay(context);
                }

                if (context.ObjectInteracted(arg1: new[] {12000062}, arg2: 0)) {
                    return new StateAnswerIsWrong_Delay(context);
                }

                if (context.ObjectInteracted(arg1: new[] {12000063}, arg2: 0)) {
                    return new StateAnswerIsWrong_Delay(context);
                }

                if (context.ObjectInteracted(arg1: new[] {12000064}, arg2: 0)) {
                    return new StateAnswerIsWrong_Delay(context);
                }

                if (context.ObjectInteracted(arg1: new[] {12000065}, arg2: 0)) {
                    return new StateAnswerIsWrong_Delay(context);
                }

                if (context.GetUserValue(key: "Reset") == 1) {
                    return new StateResetDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckAnswer05_Delay : TriggerState {
            internal StateCheckAnswer05_Delay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Reset") == 1) {
                    return new StateResetDelay(context);
                }

                if (context.WaitTick(waitTick: 500)) {
                    return new StateAnswerIsRight(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetInteractObject(arg1: new[] {12000060}, arg2: 1);
            }
        }

        private class StateAnswerIsRight : TriggerState {
            internal StateAnswerIsRight(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 11001, key: "PlayC", value: 0);
                context.SetUserValue(triggerId: 11002, key: "PlayD", value: 0);
                context.SetUserValue(triggerId: 11003, key: "PlayE", value: 0);
                context.SetUserValue(triggerId: 11004, key: "PlayF", value: 0);
                context.SetUserValue(triggerId: 11005, key: "PlayG", value: 0);
                context.SetUserValue(triggerId: 11006, key: "PlayA", value: 0);
                context.SetUserValue(triggerId: 11007, key: "PlayB", value: 0);
                context.SetUserValue(triggerId: 11008, key: "PlayHighC", value: 0);
                context.SetUserValue(triggerId: 11000, key: "AnswerIsRight", value: 1);
                context.SetInteractObject(arg1: new[] {12000058, 12000059, 12000060, 12000061, 12000062, 12000063, 12000064, 12000065}, arg2: 0);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Reset") == 1) {
                    return new StateResetDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateAnswerIsWrong_Delay : TriggerState {
            internal StateAnswerIsWrong_Delay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 11001, key: "PlayC", value: 0);
                context.SetUserValue(triggerId: 11001, key: "PlayC", value: 0);
                context.SetUserValue(triggerId: 11002, key: "PlayD", value: 0);
                context.SetUserValue(triggerId: 11003, key: "PlayE", value: 0);
                context.SetUserValue(triggerId: 11004, key: "PlayF", value: 0);
                context.SetUserValue(triggerId: 11005, key: "PlayG", value: 0);
                context.SetUserValue(triggerId: 11006, key: "PlayA", value: 0);
                context.SetUserValue(triggerId: 11007, key: "PlayB", value: 0);
                context.SetUserValue(triggerId: 11008, key: "PlayHighC", value: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateAnswerIsWrong(context);
                }

                if (context.GetUserValue(key: "Reset") == 1) {
                    return new StateResetDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateAnswerIsWrong : TriggerState {
            internal StateAnswerIsWrong(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 11000, key: "AnswerIsWrong", value: 1);
                context.SetInteractObject(arg1: new[] {12000058, 12000059, 12000060, 12000061, 12000062, 12000063, 12000064, 12000065}, arg2: 0);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Reset") == 1) {
                    return new StateResetDelay(context);
                }

                if (context.GetUserValue(key: "Reset") == 0) {
                    return new StateMelodyPlay01_ReStartDelay01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMelodyPlay01_ReStartDelay01 : TriggerState {
            internal StateMelodyPlay01_ReStartDelay01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Reset") == 1) {
                    return new StateResetDelay(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new StateMelodyPlay01_ReStartDelay02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMelodyPlay01_ReStartDelay02 : TriggerState {
            internal StateMelodyPlay01_ReStartDelay02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {4301}, arg2: true);
                context.SetActor(arg1: 11001, arg2: true, arg3: "ks_quest_musical_B01_red");
                context.SetActor(arg1: 11002, arg2: true, arg3: "ks_quest_musical_B01_orange");
                context.SetActor(arg1: 11003, arg2: true, arg3: "ks_quest_musical_B01_yellow");
                context.SetActor(arg1: 11004, arg2: true, arg3: "ks_quest_musical_B01_green");
                context.SetActor(arg1: 11005, arg2: true, arg3: "ks_quest_musical_B01_blue");
                context.SetActor(arg1: 11006, arg2: true, arg3: "ks_quest_musical_B01_navy");
                context.SetActor(arg1: 11007, arg2: true, arg3: "ks_quest_musical_B01_purple");
                context.SetActor(arg1: 11008, arg2: true, arg3: "ks_quest_musical_B01_pink");
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Reset") == 1) {
                    return new StateResetDelay(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new StateStartMelodyQuiz_Delay03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartMelodyQuiz_Delay03 : TriggerState {
            internal StateStartMelodyQuiz_Delay03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 11001, arg2: true, arg3: "ks_quest_musical_B01_off");
                context.SetActor(arg1: 11002, arg2: true, arg3: "ks_quest_musical_B01_off");
                context.SetActor(arg1: 11003, arg2: true, arg3: "ks_quest_musical_B01_off");
                context.SetActor(arg1: 11004, arg2: true, arg3: "ks_quest_musical_B01_off");
                context.SetActor(arg1: 11005, arg2: true, arg3: "ks_quest_musical_B01_off");
                context.SetActor(arg1: 11006, arg2: true, arg3: "ks_quest_musical_B01_off");
                context.SetActor(arg1: 11007, arg2: true, arg3: "ks_quest_musical_B01_off");
                context.SetActor(arg1: 11008, arg2: true, arg3: "ks_quest_musical_B01_off");
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Reset") == 1) {
                    return new StateResetDelay(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new StateMelodyPlay01_Start(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateResetDelay : TriggerState {
            internal StateResetDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}