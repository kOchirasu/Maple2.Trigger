using System;

namespace Maple2.Trigger._02020003_bf {
    public static class _11000_minipuzzle_melody {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ResetTimer(arg1: "1");
                context.ResetTimer(arg1: "2");
                context.EnableLocalCamera(isEnable: false);
                context.SetInteractObject(arg1: new int[] {12000202}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {12000074}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {12000058}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {12000059}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {12000060}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {12000061}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {12000062}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {12000063}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {12000064}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {12000065}, arg2: 2);
                context.SetUserValue(key: "AnswerIsRight", value: 0);
                context.SetUserValue(key: "AnswerIsWrong", value: 0);
                context.SetActor(arg1: 11001, arg2: true, arg3: "ks_quest_musical_B01_off");
                context.SetActor(arg1: 11002, arg2: true, arg3: "ks_quest_musical_B01_off");
                context.SetActor(arg1: 11003, arg2: true, arg3: "ks_quest_musical_B01_off");
                context.SetActor(arg1: 11004, arg2: true, arg3: "ks_quest_musical_B01_off");
                context.SetActor(arg1: 11005, arg2: true, arg3: "ks_quest_musical_B01_off");
                context.SetActor(arg1: 11006, arg2: true, arg3: "ks_quest_musical_B01_off");
                context.SetActor(arg1: 11007, arg2: true, arg3: "ks_quest_musical_B01_off");
                context.SetActor(arg1: 11008, arg2: true, arg3: "ks_quest_musical_B01_off");
                context.SetActor(arg1: 11101, arg2: true, arg3: "ks_quest_musical_A01_off");
                context.SetActor(arg1: 11102, arg2: true, arg3: "ks_quest_musical_A01_off");
                context.SetActor(arg1: 11103, arg2: true, arg3: "ks_quest_musical_A01_off");
                context.SetActor(arg1: 11104, arg2: true, arg3: "ks_quest_musical_A01_off");
                context.SetActor(arg1: 11105, arg2: true, arg3: "ks_quest_musical_A01_off");
                context.SetActor(arg1: 11106, arg2: true, arg3: "ks_quest_musical_A01_off");
                context.SetActor(arg1: 11107, arg2: true, arg3: "ks_quest_musical_A01_off");
                context.SetActor(arg1: 11108, arg2: true, arg3: "ks_quest_musical_A01_off");
                context.SetEffect(arg1: new int[] {11201}, arg2: false);
                context.SetEffect(arg1: new int[] {11202}, arg2: false);
                context.SetEffect(arg1: new int[] {11203}, arg2: false);
                context.SetEffect(arg1: new int[] {11204}, arg2: false);
                context.SetEffect(arg1: new int[] {11205}, arg2: false);
                context.SetEffect(arg1: new int[] {11206}, arg2: false);
                context.SetEffect(arg1: new int[] {11207}, arg2: false);
                context.SetEffect(arg1: new int[] {11208}, arg2: false);
                context.SetEffect(arg1: new int[] {11300}, arg2: false);
                context.SetEffect(arg1: new int[] {11301}, arg2: false);
                context.SetEffect(arg1: new int[] {11302}, arg2: false);
            }

            public override void Execute() {
                if (context.UserValue(key: "TimeEventOn", value: 1)) {
                    context.State = new StateSetting(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSetting : TriggerState {
            internal StateSetting(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.EnableLocalCamera(isEnable: true);
                context.SetInteractObject(arg1: new int[] {12000074}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {12000074}, arg2: 0)) {
                    context.SetTimer(arg1: "1", arg2: 120, arg3: true, arg4: false, arg5: 0);
                    context.State = new StateStartMelodyQuiz_Delay01(context);
                    return;
                }

                if (context.UserValue(key: "TimeEventOn", value: 0)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateStartMelodyQuiz_Delay01 : TriggerState {
            internal StateStartMelodyQuiz_Delay01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {11301}, arg2: true);
                context.SetActor(arg1: 11001, arg2: true, arg3: "ks_quest_musical_B01_red");
                context.SetActor(arg1: 11002, arg2: true, arg3: "ks_quest_musical_B01_orange");
                context.SetActor(arg1: 11003, arg2: true, arg3: "ks_quest_musical_B01_yellow");
                context.SetActor(arg1: 11004, arg2: true, arg3: "ks_quest_musical_B01_green");
                context.SetActor(arg1: 11005, arg2: true, arg3: "ks_quest_musical_B01_blue");
                context.SetActor(arg1: 11006, arg2: true, arg3: "ks_quest_musical_B01_navy");
                context.SetActor(arg1: 11007, arg2: true, arg3: "ks_quest_musical_B01_purple");
                context.SetActor(arg1: 11008, arg2: true, arg3: "ks_quest_musical_B01_pink");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateStartMelodyQuiz_Delay02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateStartMelodyQuiz_Delay02 : TriggerState {
            internal StateStartMelodyQuiz_Delay02(ITriggerContext context) : base(context) { }

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

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateStartMelodyQuiz_Random(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateStartMelodyQuiz_Random : TriggerState {
            internal StateStartMelodyQuiz_Random(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.RandomCondition(arg1: 50f)) {
                    context.State = new StateMelodyQuizPattern01(context);
                    return;
                }

                if (context.RandomCondition(arg1: 50f)) {
                    context.State = new StateMelodyQuizPattern02(context);
                    return;
                }

                if (context.RandomCondition(arg1: 50f)) {
                    context.State = new StateMelodyQuizPattern03(context);
                    return;
                }

                if (context.RandomCondition(arg1: 50f)) {
                    context.State = new StateMelodyQuizPattern04(context);
                    return;
                }

                if (context.RandomCondition(arg1: 50f)) {
                    context.State = new StateMelodyQuizPattern05(context);
                    return;
                }

                if (context.RandomCondition(arg1: 50f)) {
                    context.State = new StateMelodyQuizPattern06(context);
                    return;
                }

                if (context.RandomCondition(arg1: 50f)) {
                    context.State = new StateMelodyQuizPattern07(context);
                    return;
                }

                if (context.RandomCondition(arg1: 50f)) {
                    context.State = new StateMelodyQuizPattern08(context);
                    return;
                }

                if (context.RandomCondition(arg1: 50f)) {
                    context.State = new StateMelodyQuizPattern09(context);
                    return;
                }

                if (context.RandomCondition(arg1: 50f)) {
                    context.State = new StateMelodyQuizPattern10(context);
                    return;
                }

                if (context.RandomCondition(arg1: 50f)) {
                    context.State = new StateMelodyQuizPattern11(context);
                    return;
                }

                if (context.RandomCondition(arg1: 50f)) {
                    context.State = new StateMelodyQuizPattern12(context);
                    return;
                }

                if (context.RandomCondition(arg1: 50f)) {
                    context.State = new StateMelodyQuizPattern13(context);
                    return;
                }

                if (context.RandomCondition(arg1: 50f)) {
                    context.State = new StateMelodyQuizPattern14(context);
                    return;
                }

                if (context.RandomCondition(arg1: 50f)) {
                    context.State = new StateMelodyQuizPattern15(context);
                    return;
                }

                if (context.RandomCondition(arg1: 50f)) {
                    context.State = new StateMelodyQuizPattern16(context);
                    return;
                }

                if (context.RandomCondition(arg1: 50f)) {
                    context.State = new StateMelodyQuizPattern17(context);
                    return;
                }

                if (context.RandomCondition(arg1: 50f)) {
                    context.State = new StateMelodyQuizPattern18(context);
                    return;
                }

                if (context.RandomCondition(arg1: 50f)) {
                    context.State = new StateMelodyQuizPattern19(context);
                    return;
                }

                if (context.RandomCondition(arg1: 50f)) {
                    context.State = new StateMelodyQuizPattern20(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMelodyQuizPattern01 : TriggerState {
            internal StateMelodyQuizPattern01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "PatternPick", value: 101);
                context.SetUserValue(triggerID: 101, key: "PatternPick", value: 1);
            }

            public override void Execute() {
                if (context.UserValue(key: "AnswerIsRight", value: 1)) {
                    context.State = new StateEndMelodyQuiz_Success(context);
                    return;
                }

                if (context.UserValue(key: "AnswerIsWrong", value: 1)) {
                    context.State = new StateEndMelodyQuiz_Fail(context);
                    return;
                }

                if (context.TimeExpired(arg1: "1")) {
                    context.State = new StateMelodyQuiz_Fail_Quit(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetUserValue(triggerID: 101, key: "Reset", value: 1);
            }
        }

        private class StateMelodyQuizPattern02 : TriggerState {
            internal StateMelodyQuizPattern02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "PatternPick", value: 102);
                context.SetUserValue(triggerID: 102, key: "PatternPick", value: 1);
            }

            public override void Execute() {
                if (context.UserValue(key: "AnswerIsRight", value: 1)) {
                    context.State = new StateEndMelodyQuiz_Success(context);
                    return;
                }

                if (context.UserValue(key: "AnswerIsWrong", value: 1)) {
                    context.State = new StateEndMelodyQuiz_Fail(context);
                    return;
                }

                if (context.TimeExpired(arg1: "1")) {
                    context.State = new StateMelodyQuiz_Fail_Quit(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetUserValue(triggerID: 102, key: "Reset", value: 1);
            }
        }

        private class StateMelodyQuizPattern03 : TriggerState {
            internal StateMelodyQuizPattern03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "PatternPick", value: 103);
                context.SetUserValue(triggerID: 103, key: "PatternPick", value: 1);
            }

            public override void Execute() {
                if (context.UserValue(key: "AnswerIsRight", value: 1)) {
                    context.State = new StateEndMelodyQuiz_Success(context);
                    return;
                }

                if (context.UserValue(key: "AnswerIsWrong", value: 1)) {
                    context.State = new StateEndMelodyQuiz_Fail(context);
                    return;
                }

                if (context.TimeExpired(arg1: "1")) {
                    context.State = new StateMelodyQuiz_Fail_Quit(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetUserValue(triggerID: 103, key: "Reset", value: 1);
            }
        }

        private class StateMelodyQuizPattern04 : TriggerState {
            internal StateMelodyQuizPattern04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "PatternPick", value: 104);
                context.SetUserValue(triggerID: 104, key: "PatternPick", value: 1);
            }

            public override void Execute() {
                if (context.UserValue(key: "AnswerIsRight", value: 1)) {
                    context.State = new StateEndMelodyQuiz_Success(context);
                    return;
                }

                if (context.UserValue(key: "AnswerIsWrong", value: 1)) {
                    context.State = new StateEndMelodyQuiz_Fail(context);
                    return;
                }

                if (context.TimeExpired(arg1: "1")) {
                    context.State = new StateMelodyQuiz_Fail_Quit(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetUserValue(triggerID: 104, key: "Reset", value: 1);
            }
        }

        private class StateMelodyQuizPattern05 : TriggerState {
            internal StateMelodyQuizPattern05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "PatternPick", value: 105);
                context.SetUserValue(triggerID: 105, key: "PatternPick", value: 1);
            }

            public override void Execute() {
                if (context.UserValue(key: "AnswerIsRight", value: 1)) {
                    context.State = new StateEndMelodyQuiz_Success(context);
                    return;
                }

                if (context.UserValue(key: "AnswerIsWrong", value: 1)) {
                    context.State = new StateEndMelodyQuiz_Fail(context);
                    return;
                }

                if (context.TimeExpired(arg1: "1")) {
                    context.State = new StateMelodyQuiz_Fail_Quit(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetUserValue(triggerID: 105, key: "Reset", value: 1);
            }
        }

        private class StateMelodyQuizPattern06 : TriggerState {
            internal StateMelodyQuizPattern06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "PatternPick", value: 106);
                context.SetUserValue(triggerID: 106, key: "PatternPick", value: 1);
            }

            public override void Execute() {
                if (context.UserValue(key: "AnswerIsRight", value: 1)) {
                    context.State = new StateEndMelodyQuiz_Success(context);
                    return;
                }

                if (context.UserValue(key: "AnswerIsWrong", value: 1)) {
                    context.State = new StateEndMelodyQuiz_Fail(context);
                    return;
                }

                if (context.TimeExpired(arg1: "1")) {
                    context.State = new StateMelodyQuiz_Fail_Quit(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetUserValue(triggerID: 106, key: "Reset", value: 1);
            }
        }

        private class StateMelodyQuizPattern07 : TriggerState {
            internal StateMelodyQuizPattern07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "PatternPick", value: 107);
                context.SetUserValue(triggerID: 107, key: "PatternPick", value: 1);
            }

            public override void Execute() {
                if (context.UserValue(key: "AnswerIsRight", value: 1)) {
                    context.State = new StateEndMelodyQuiz_Success(context);
                    return;
                }

                if (context.UserValue(key: "AnswerIsWrong", value: 1)) {
                    context.State = new StateEndMelodyQuiz_Fail(context);
                    return;
                }

                if (context.TimeExpired(arg1: "1")) {
                    context.State = new StateMelodyQuiz_Fail_Quit(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetUserValue(triggerID: 107, key: "Reset", value: 1);
            }
        }

        private class StateMelodyQuizPattern08 : TriggerState {
            internal StateMelodyQuizPattern08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "PatternPick", value: 108);
                context.SetUserValue(triggerID: 108, key: "PatternPick", value: 1);
            }

            public override void Execute() {
                if (context.UserValue(key: "AnswerIsRight", value: 1)) {
                    context.State = new StateEndMelodyQuiz_Success(context);
                    return;
                }

                if (context.UserValue(key: "AnswerIsWrong", value: 1)) {
                    context.State = new StateEndMelodyQuiz_Fail(context);
                    return;
                }

                if (context.TimeExpired(arg1: "1")) {
                    context.State = new StateMelodyQuiz_Fail_Quit(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetUserValue(triggerID: 108, key: "Reset", value: 1);
            }
        }

        private class StateMelodyQuizPattern09 : TriggerState {
            internal StateMelodyQuizPattern09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "PatternPick", value: 109);
                context.SetUserValue(triggerID: 109, key: "PatternPick", value: 1);
            }

            public override void Execute() {
                if (context.UserValue(key: "AnswerIsRight", value: 1)) {
                    context.State = new StateEndMelodyQuiz_Success(context);
                    return;
                }

                if (context.UserValue(key: "AnswerIsWrong", value: 1)) {
                    context.State = new StateEndMelodyQuiz_Fail(context);
                    return;
                }

                if (context.TimeExpired(arg1: "1")) {
                    context.State = new StateMelodyQuiz_Fail_Quit(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetUserValue(triggerID: 109, key: "Reset", value: 1);
            }
        }

        private class StateMelodyQuizPattern10 : TriggerState {
            internal StateMelodyQuizPattern10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "PatternPick", value: 110);
                context.SetUserValue(triggerID: 110, key: "PatternPick", value: 1);
            }

            public override void Execute() {
                if (context.UserValue(key: "AnswerIsRight", value: 1)) {
                    context.State = new StateEndMelodyQuiz_Success(context);
                    return;
                }

                if (context.UserValue(key: "AnswerIsWrong", value: 1)) {
                    context.State = new StateEndMelodyQuiz_Fail(context);
                    return;
                }

                if (context.TimeExpired(arg1: "1")) {
                    context.State = new StateMelodyQuiz_Fail_Quit(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetUserValue(triggerID: 110, key: "Reset", value: 1);
            }
        }

        private class StateMelodyQuizPattern11 : TriggerState {
            internal StateMelodyQuizPattern11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "PatternPick", value: 111);
                context.SetUserValue(triggerID: 111, key: "PatternPick", value: 1);
            }

            public override void Execute() {
                if (context.UserValue(key: "AnswerIsRight", value: 1)) {
                    context.State = new StateEndMelodyQuiz_Success(context);
                    return;
                }

                if (context.UserValue(key: "AnswerIsWrong", value: 1)) {
                    context.State = new StateEndMelodyQuiz_Fail(context);
                    return;
                }

                if (context.TimeExpired(arg1: "1")) {
                    context.State = new StateMelodyQuiz_Fail_Quit(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetUserValue(triggerID: 111, key: "Reset", value: 1);
            }
        }

        private class StateMelodyQuizPattern12 : TriggerState {
            internal StateMelodyQuizPattern12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "PatternPick", value: 112);
                context.SetUserValue(triggerID: 112, key: "PatternPick", value: 1);
            }

            public override void Execute() {
                if (context.UserValue(key: "AnswerIsRight", value: 1)) {
                    context.State = new StateEndMelodyQuiz_Success(context);
                    return;
                }

                if (context.UserValue(key: "AnswerIsWrong", value: 1)) {
                    context.State = new StateEndMelodyQuiz_Fail(context);
                    return;
                }

                if (context.TimeExpired(arg1: "1")) {
                    context.State = new StateMelodyQuiz_Fail_Quit(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetUserValue(triggerID: 112, key: "Reset", value: 1);
            }
        }

        private class StateMelodyQuizPattern13 : TriggerState {
            internal StateMelodyQuizPattern13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "PatternPick", value: 113);
                context.SetUserValue(triggerID: 113, key: "PatternPick", value: 1);
            }

            public override void Execute() {
                if (context.UserValue(key: "AnswerIsRight", value: 1)) {
                    context.State = new StateEndMelodyQuiz_Success(context);
                    return;
                }

                if (context.UserValue(key: "AnswerIsWrong", value: 1)) {
                    context.State = new StateEndMelodyQuiz_Fail(context);
                    return;
                }

                if (context.TimeExpired(arg1: "1")) {
                    context.State = new StateMelodyQuiz_Fail_Quit(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetUserValue(triggerID: 113, key: "Reset", value: 1);
            }
        }

        private class StateMelodyQuizPattern14 : TriggerState {
            internal StateMelodyQuizPattern14(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "PatternPick", value: 114);
                context.SetUserValue(triggerID: 114, key: "PatternPick", value: 1);
            }

            public override void Execute() {
                if (context.UserValue(key: "AnswerIsRight", value: 1)) {
                    context.State = new StateEndMelodyQuiz_Success(context);
                    return;
                }

                if (context.UserValue(key: "AnswerIsWrong", value: 1)) {
                    context.State = new StateEndMelodyQuiz_Fail(context);
                    return;
                }

                if (context.TimeExpired(arg1: "1")) {
                    context.State = new StateMelodyQuiz_Fail_Quit(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetUserValue(triggerID: 114, key: "Reset", value: 1);
            }
        }

        private class StateMelodyQuizPattern15 : TriggerState {
            internal StateMelodyQuizPattern15(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "PatternPick", value: 115);
                context.SetUserValue(triggerID: 115, key: "PatternPick", value: 1);
            }

            public override void Execute() {
                if (context.UserValue(key: "AnswerIsRight", value: 1)) {
                    context.State = new StateEndMelodyQuiz_Success(context);
                    return;
                }

                if (context.UserValue(key: "AnswerIsWrong", value: 1)) {
                    context.State = new StateEndMelodyQuiz_Fail(context);
                    return;
                }

                if (context.TimeExpired(arg1: "1")) {
                    context.State = new StateMelodyQuiz_Fail_Quit(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetUserValue(triggerID: 115, key: "Reset", value: 1);
            }
        }

        private class StateMelodyQuizPattern16 : TriggerState {
            internal StateMelodyQuizPattern16(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "PatternPick", value: 116);
                context.SetUserValue(triggerID: 116, key: "PatternPick", value: 1);
            }

            public override void Execute() {
                if (context.UserValue(key: "AnswerIsRight", value: 1)) {
                    context.State = new StateEndMelodyQuiz_Success(context);
                    return;
                }

                if (context.UserValue(key: "AnswerIsWrong", value: 1)) {
                    context.State = new StateEndMelodyQuiz_Fail(context);
                    return;
                }

                if (context.TimeExpired(arg1: "1")) {
                    context.State = new StateMelodyQuiz_Fail_Quit(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetUserValue(triggerID: 116, key: "Reset", value: 1);
            }
        }

        private class StateMelodyQuizPattern17 : TriggerState {
            internal StateMelodyQuizPattern17(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "PatternPick", value: 117);
                context.SetUserValue(triggerID: 117, key: "PatternPick", value: 1);
            }

            public override void Execute() {
                if (context.UserValue(key: "AnswerIsRight", value: 1)) {
                    context.State = new StateEndMelodyQuiz_Success(context);
                    return;
                }

                if (context.UserValue(key: "AnswerIsWrong", value: 1)) {
                    context.State = new StateEndMelodyQuiz_Fail(context);
                    return;
                }

                if (context.TimeExpired(arg1: "1")) {
                    context.State = new StateMelodyQuiz_Fail_Quit(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetUserValue(triggerID: 117, key: "Reset", value: 1);
            }
        }

        private class StateMelodyQuizPattern18 : TriggerState {
            internal StateMelodyQuizPattern18(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "PatternPick", value: 118);
                context.SetUserValue(triggerID: 118, key: "PatternPick", value: 1);
            }

            public override void Execute() {
                if (context.UserValue(key: "AnswerIsRight", value: 1)) {
                    context.State = new StateEndMelodyQuiz_Success(context);
                    return;
                }

                if (context.UserValue(key: "AnswerIsWrong", value: 1)) {
                    context.State = new StateEndMelodyQuiz_Fail(context);
                    return;
                }

                if (context.TimeExpired(arg1: "1")) {
                    context.State = new StateMelodyQuiz_Fail_Quit(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetUserValue(triggerID: 118, key: "Reset", value: 1);
            }
        }

        private class StateMelodyQuizPattern19 : TriggerState {
            internal StateMelodyQuizPattern19(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "PatternPick", value: 119);
                context.SetUserValue(triggerID: 119, key: "PatternPick", value: 1);
            }

            public override void Execute() {
                if (context.UserValue(key: "AnswerIsRight", value: 1)) {
                    context.State = new StateEndMelodyQuiz_Success(context);
                    return;
                }

                if (context.UserValue(key: "AnswerIsWrong", value: 1)) {
                    context.State = new StateEndMelodyQuiz_Fail(context);
                    return;
                }

                if (context.TimeExpired(arg1: "1")) {
                    context.State = new StateMelodyQuiz_Fail_Quit(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetUserValue(triggerID: 119, key: "Reset", value: 1);
            }
        }

        private class StateMelodyQuizPattern20 : TriggerState {
            internal StateMelodyQuizPattern20(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "PatternPick", value: 120);
                context.SetUserValue(triggerID: 120, key: "PatternPick", value: 1);
            }

            public override void Execute() {
                if (context.UserValue(key: "AnswerIsRight", value: 1)) {
                    context.State = new StateEndMelodyQuiz_Success(context);
                    return;
                }

                if (context.UserValue(key: "AnswerIsWrong", value: 1)) {
                    context.State = new StateEndMelodyQuiz_Fail(context);
                    return;
                }

                if (context.TimeExpired(arg1: "1")) {
                    context.State = new StateMelodyQuiz_Fail_Quit(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetUserValue(triggerID: 120, key: "Reset", value: 1);
            }
        }

        private class StateEndMelodyQuiz_Success : TriggerState {
            internal StateEndMelodyQuiz_Success(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new int[] {11901}, arg2: 71001012, arg3: 1, arg4: false, arg5: false);
                context.SetEffect(arg1: new int[] {11300}, arg2: true);
                context.SetInteractObject(arg1: new int[] {12000202}, arg2: 1);
                context.SetTimer(arg1: "2", arg2: 60, arg3: true, arg4: false, arg5: 0);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {12000202}, arg2: 0)) {
                    context.State = new StateMelodyQuiz_Success_Quit(context);
                    return;
                }

                if (context.TimeExpired(arg1: "2")) {
                    context.State = new StateMelodyQuiz_Success_Quit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEndMelodyQuiz_Fail : TriggerState {
            internal StateEndMelodyQuiz_Fail(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {11302}, arg2: true);
            }

            public override void Execute() {
                if (context.UserValue(key: "TimeEventOn", value: 0)) {
                    context.State = new StateEndMelodyQuiz_Fail_2(context);
                    return;
                }

                if (context.TimeExpired(arg1: "1")) {
                    context.State = new StateMelodyQuiz_Fail_Quit(context);
                    return;
                }

                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateMelodyQuiz_Retry(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEndMelodyQuiz_Fail_2 : TriggerState {
            internal StateEndMelodyQuiz_Fail_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new StateWait(context);
                    return;
                }

                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateMelodyQuiz_Retry(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMelodyQuiz_Retry : TriggerState {
            internal StateMelodyQuiz_Retry(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "AnswerIsWrong", value: 0);
            }

            public override void Execute() {
                if (context.UserValue(key: "PatternPick", value: 101)) {
                    context.State = new StateMelodyQuizPattern01(context);
                    return;
                }

                if (context.UserValue(key: "PatternPick", value: 102)) {
                    context.State = new StateMelodyQuizPattern02(context);
                    return;
                }

                if (context.UserValue(key: "PatternPick", value: 103)) {
                    context.State = new StateMelodyQuizPattern03(context);
                    return;
                }

                if (context.UserValue(key: "PatternPick", value: 104)) {
                    context.State = new StateMelodyQuizPattern04(context);
                    return;
                }

                if (context.UserValue(key: "PatternPick", value: 105)) {
                    context.State = new StateMelodyQuizPattern05(context);
                    return;
                }

                if (context.UserValue(key: "PatternPick", value: 106)) {
                    context.State = new StateMelodyQuizPattern06(context);
                    return;
                }

                if (context.UserValue(key: "PatternPick", value: 107)) {
                    context.State = new StateMelodyQuizPattern07(context);
                    return;
                }

                if (context.UserValue(key: "PatternPick", value: 108)) {
                    context.State = new StateMelodyQuizPattern08(context);
                    return;
                }

                if (context.UserValue(key: "PatternPick", value: 109)) {
                    context.State = new StateMelodyQuizPattern09(context);
                    return;
                }

                if (context.UserValue(key: "PatternPick", value: 110)) {
                    context.State = new StateMelodyQuizPattern10(context);
                    return;
                }

                if (context.UserValue(key: "PatternPick", value: 111)) {
                    context.State = new StateMelodyQuizPattern11(context);
                    return;
                }

                if (context.UserValue(key: "PatternPick", value: 112)) {
                    context.State = new StateMelodyQuizPattern12(context);
                    return;
                }

                if (context.UserValue(key: "PatternPick", value: 113)) {
                    context.State = new StateMelodyQuizPattern13(context);
                    return;
                }

                if (context.UserValue(key: "PatternPick", value: 114)) {
                    context.State = new StateMelodyQuizPattern14(context);
                    return;
                }

                if (context.UserValue(key: "PatternPick", value: 115)) {
                    context.State = new StateMelodyQuizPattern15(context);
                    return;
                }

                if (context.UserValue(key: "PatternPick", value: 116)) {
                    context.State = new StateMelodyQuizPattern16(context);
                    return;
                }

                if (context.UserValue(key: "PatternPick", value: 117)) {
                    context.State = new StateMelodyQuizPattern17(context);
                    return;
                }

                if (context.UserValue(key: "PatternPick", value: 118)) {
                    context.State = new StateMelodyQuizPattern18(context);
                    return;
                }

                if (context.UserValue(key: "PatternPick", value: 119)) {
                    context.State = new StateMelodyQuizPattern19(context);
                    return;
                }

                if (context.UserValue(key: "PatternPick", value: 120)) {
                    context.State = new StateMelodyQuizPattern20(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMelodyQuiz_Fail_Quit : TriggerState {
            internal StateMelodyQuiz_Fail_Quit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ResetTimer(arg1: "1");
                context.ResetTimer(arg1: "2");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMelodyQuiz_Success_Quit : TriggerState {
            internal StateMelodyQuiz_Success_Quit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "TimeEventOn", value: 0);
                context.ResetTimer(arg1: "1");
                context.ResetTimer(arg1: "2");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}