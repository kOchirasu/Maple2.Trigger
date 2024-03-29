namespace Maple2.Trigger._02020071_bf {
    public static class _11000_minipuzzle_melody {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ResetTimer(timerId: "1");
                context.ResetTimer(timerId: "2");
                context.EnableLocalCamera(enabled: false);
                context.SetInteractObject(interactIds: new []{12000203, 12000074, 12000058, 12000059, 12000060, 12000061, 12000062, 12000063, 12000064, 12000065}, state: 2);
                context.SetUserValue(key: "AnswerIsRight", value: 0);
                context.SetUserValue(key: "AnswerIsWrong", value: 0);
                context.SetActor(triggerId: 11001, visible: true, initialSequence: "ks_quest_musical_B01_off");
                context.SetActor(triggerId: 11002, visible: true, initialSequence: "ks_quest_musical_B01_off");
                context.SetActor(triggerId: 11003, visible: true, initialSequence: "ks_quest_musical_B01_off");
                context.SetActor(triggerId: 11004, visible: true, initialSequence: "ks_quest_musical_B01_off");
                context.SetActor(triggerId: 11005, visible: true, initialSequence: "ks_quest_musical_B01_off");
                context.SetActor(triggerId: 11006, visible: true, initialSequence: "ks_quest_musical_B01_off");
                context.SetActor(triggerId: 11007, visible: true, initialSequence: "ks_quest_musical_B01_off");
                context.SetActor(triggerId: 11008, visible: true, initialSequence: "ks_quest_musical_B01_off");
                context.SetActor(triggerId: 11101, visible: true, initialSequence: "ks_quest_musical_A01_off");
                context.SetActor(triggerId: 11102, visible: true, initialSequence: "ks_quest_musical_A01_off");
                context.SetActor(triggerId: 11103, visible: true, initialSequence: "ks_quest_musical_A01_off");
                context.SetActor(triggerId: 11104, visible: true, initialSequence: "ks_quest_musical_A01_off");
                context.SetActor(triggerId: 11105, visible: true, initialSequence: "ks_quest_musical_A01_off");
                context.SetActor(triggerId: 11106, visible: true, initialSequence: "ks_quest_musical_A01_off");
                context.SetActor(triggerId: 11107, visible: true, initialSequence: "ks_quest_musical_A01_off");
                context.SetActor(triggerId: 11108, visible: true, initialSequence: "ks_quest_musical_A01_off");
                context.SetEffect(triggerIds: new []{11201, 11202, 11203, 11204, 11205, 11206, 11207, 11208, 11300, 11301, 11302}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "TimeEventOn") == 1) {
                    return new StateSetting(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetting : TriggerState {
            internal StateSetting(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.EnableLocalCamera(enabled: true);
                context.SetInteractObject(interactIds: new []{12000074}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{12000074}, arg2: 0)) {
                    context.SetTimer(timerId: "1", seconds: 120, autoRemove: true, display: false, vOffset: 0);
                    return new StateStartMelodyQuiz_Delay01(context);
                }

                if (context.GetUserValue(key: "TimeEventOn") == 0) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartMelodyQuiz_Delay01 : TriggerState {
            internal StateStartMelodyQuiz_Delay01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{11301}, visible: true);
                context.SetActor(triggerId: 11001, visible: true, initialSequence: "ks_quest_musical_B01_red");
                context.SetActor(triggerId: 11002, visible: true, initialSequence: "ks_quest_musical_B01_orange");
                context.SetActor(triggerId: 11003, visible: true, initialSequence: "ks_quest_musical_B01_yellow");
                context.SetActor(triggerId: 11004, visible: true, initialSequence: "ks_quest_musical_B01_green");
                context.SetActor(triggerId: 11005, visible: true, initialSequence: "ks_quest_musical_B01_blue");
                context.SetActor(triggerId: 11006, visible: true, initialSequence: "ks_quest_musical_B01_navy");
                context.SetActor(triggerId: 11007, visible: true, initialSequence: "ks_quest_musical_B01_purple");
                context.SetActor(triggerId: 11008, visible: true, initialSequence: "ks_quest_musical_B01_pink");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateStartMelodyQuiz_Delay02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartMelodyQuiz_Delay02 : TriggerState {
            internal StateStartMelodyQuiz_Delay02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 11001, visible: true, initialSequence: "ks_quest_musical_B01_off");
                context.SetActor(triggerId: 11002, visible: true, initialSequence: "ks_quest_musical_B01_off");
                context.SetActor(triggerId: 11003, visible: true, initialSequence: "ks_quest_musical_B01_off");
                context.SetActor(triggerId: 11004, visible: true, initialSequence: "ks_quest_musical_B01_off");
                context.SetActor(triggerId: 11005, visible: true, initialSequence: "ks_quest_musical_B01_off");
                context.SetActor(triggerId: 11006, visible: true, initialSequence: "ks_quest_musical_B01_off");
                context.SetActor(triggerId: 11007, visible: true, initialSequence: "ks_quest_musical_B01_off");
                context.SetActor(triggerId: 11008, visible: true, initialSequence: "ks_quest_musical_B01_off");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateStartMelodyQuiz_Random(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartMelodyQuiz_Random : TriggerState {
            internal StateStartMelodyQuiz_Random(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 50)) {
                    return new StateMelodyQuizPattern01(context);
                }

                if (context.RandomCondition(rate: 50)) {
                    return new StateMelodyQuizPattern02(context);
                }

                if (context.RandomCondition(rate: 50)) {
                    return new StateMelodyQuizPattern03(context);
                }

                if (context.RandomCondition(rate: 50)) {
                    return new StateMelodyQuizPattern04(context);
                }

                if (context.RandomCondition(rate: 50)) {
                    return new StateMelodyQuizPattern05(context);
                }

                if (context.RandomCondition(rate: 50)) {
                    return new StateMelodyQuizPattern06(context);
                }

                if (context.RandomCondition(rate: 50)) {
                    return new StateMelodyQuizPattern07(context);
                }

                if (context.RandomCondition(rate: 50)) {
                    return new StateMelodyQuizPattern08(context);
                }

                if (context.RandomCondition(rate: 50)) {
                    return new StateMelodyQuizPattern09(context);
                }

                if (context.RandomCondition(rate: 50)) {
                    return new StateMelodyQuizPattern10(context);
                }

                if (context.RandomCondition(rate: 50)) {
                    return new StateMelodyQuizPattern11(context);
                }

                if (context.RandomCondition(rate: 50)) {
                    return new StateMelodyQuizPattern12(context);
                }

                if (context.RandomCondition(rate: 50)) {
                    return new StateMelodyQuizPattern13(context);
                }

                if (context.RandomCondition(rate: 50)) {
                    return new StateMelodyQuizPattern14(context);
                }

                if (context.RandomCondition(rate: 50)) {
                    return new StateMelodyQuizPattern15(context);
                }

                if (context.RandomCondition(rate: 50)) {
                    return new StateMelodyQuizPattern16(context);
                }

                if (context.RandomCondition(rate: 50)) {
                    return new StateMelodyQuizPattern17(context);
                }

                if (context.RandomCondition(rate: 50)) {
                    return new StateMelodyQuizPattern18(context);
                }

                if (context.RandomCondition(rate: 50)) {
                    return new StateMelodyQuizPattern19(context);
                }

                if (context.RandomCondition(rate: 50)) {
                    return new StateMelodyQuizPattern20(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMelodyQuizPattern01 : TriggerState {
            internal StateMelodyQuizPattern01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "PatternPick", value: 101);
                context.SetUserValue(triggerId: 101, key: "PatternPick", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "AnswerIsRight") == 1) {
                    return new StateEndMelodyQuiz_Success(context);
                }

                if (context.GetUserValue(key: "AnswerIsWrong") == 1) {
                    return new StateEndMelodyQuiz_Fail(context);
                }

                if (context.TimeExpired(timerId: "1")) {
                    return new StateMelodyQuiz_Fail_Quit(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetUserValue(triggerId: 101, key: "Reset", value: 1);
            }
        }

        private class StateMelodyQuizPattern02 : TriggerState {
            internal StateMelodyQuizPattern02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "PatternPick", value: 102);
                context.SetUserValue(triggerId: 102, key: "PatternPick", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "AnswerIsRight") == 1) {
                    return new StateEndMelodyQuiz_Success(context);
                }

                if (context.GetUserValue(key: "AnswerIsWrong") == 1) {
                    return new StateEndMelodyQuiz_Fail(context);
                }

                if (context.TimeExpired(timerId: "1")) {
                    return new StateMelodyQuiz_Fail_Quit(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetUserValue(triggerId: 102, key: "Reset", value: 1);
            }
        }

        private class StateMelodyQuizPattern03 : TriggerState {
            internal StateMelodyQuizPattern03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "PatternPick", value: 103);
                context.SetUserValue(triggerId: 103, key: "PatternPick", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "AnswerIsRight") == 1) {
                    return new StateEndMelodyQuiz_Success(context);
                }

                if (context.GetUserValue(key: "AnswerIsWrong") == 1) {
                    return new StateEndMelodyQuiz_Fail(context);
                }

                if (context.TimeExpired(timerId: "1")) {
                    return new StateMelodyQuiz_Fail_Quit(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetUserValue(triggerId: 103, key: "Reset", value: 1);
            }
        }

        private class StateMelodyQuizPattern04 : TriggerState {
            internal StateMelodyQuizPattern04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "PatternPick", value: 104);
                context.SetUserValue(triggerId: 104, key: "PatternPick", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "AnswerIsRight") == 1) {
                    return new StateEndMelodyQuiz_Success(context);
                }

                if (context.GetUserValue(key: "AnswerIsWrong") == 1) {
                    return new StateEndMelodyQuiz_Fail(context);
                }

                if (context.TimeExpired(timerId: "1")) {
                    return new StateMelodyQuiz_Fail_Quit(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetUserValue(triggerId: 104, key: "Reset", value: 1);
            }
        }

        private class StateMelodyQuizPattern05 : TriggerState {
            internal StateMelodyQuizPattern05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "PatternPick", value: 105);
                context.SetUserValue(triggerId: 105, key: "PatternPick", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "AnswerIsRight") == 1) {
                    return new StateEndMelodyQuiz_Success(context);
                }

                if (context.GetUserValue(key: "AnswerIsWrong") == 1) {
                    return new StateEndMelodyQuiz_Fail(context);
                }

                if (context.TimeExpired(timerId: "1")) {
                    return new StateMelodyQuiz_Fail_Quit(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetUserValue(triggerId: 105, key: "Reset", value: 1);
            }
        }

        private class StateMelodyQuizPattern06 : TriggerState {
            internal StateMelodyQuizPattern06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "PatternPick", value: 106);
                context.SetUserValue(triggerId: 106, key: "PatternPick", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "AnswerIsRight") == 1) {
                    return new StateEndMelodyQuiz_Success(context);
                }

                if (context.GetUserValue(key: "AnswerIsWrong") == 1) {
                    return new StateEndMelodyQuiz_Fail(context);
                }

                if (context.TimeExpired(timerId: "1")) {
                    return new StateMelodyQuiz_Fail_Quit(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetUserValue(triggerId: 106, key: "Reset", value: 1);
            }
        }

        private class StateMelodyQuizPattern07 : TriggerState {
            internal StateMelodyQuizPattern07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "PatternPick", value: 107);
                context.SetUserValue(triggerId: 107, key: "PatternPick", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "AnswerIsRight") == 1) {
                    return new StateEndMelodyQuiz_Success(context);
                }

                if (context.GetUserValue(key: "AnswerIsWrong") == 1) {
                    return new StateEndMelodyQuiz_Fail(context);
                }

                if (context.TimeExpired(timerId: "1")) {
                    return new StateMelodyQuiz_Fail_Quit(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetUserValue(triggerId: 107, key: "Reset", value: 1);
            }
        }

        private class StateMelodyQuizPattern08 : TriggerState {
            internal StateMelodyQuizPattern08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "PatternPick", value: 108);
                context.SetUserValue(triggerId: 108, key: "PatternPick", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "AnswerIsRight") == 1) {
                    return new StateEndMelodyQuiz_Success(context);
                }

                if (context.GetUserValue(key: "AnswerIsWrong") == 1) {
                    return new StateEndMelodyQuiz_Fail(context);
                }

                if (context.TimeExpired(timerId: "1")) {
                    return new StateMelodyQuiz_Fail_Quit(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetUserValue(triggerId: 108, key: "Reset", value: 1);
            }
        }

        private class StateMelodyQuizPattern09 : TriggerState {
            internal StateMelodyQuizPattern09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "PatternPick", value: 109);
                context.SetUserValue(triggerId: 109, key: "PatternPick", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "AnswerIsRight") == 1) {
                    return new StateEndMelodyQuiz_Success(context);
                }

                if (context.GetUserValue(key: "AnswerIsWrong") == 1) {
                    return new StateEndMelodyQuiz_Fail(context);
                }

                if (context.TimeExpired(timerId: "1")) {
                    return new StateMelodyQuiz_Fail_Quit(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetUserValue(triggerId: 109, key: "Reset", value: 1);
            }
        }

        private class StateMelodyQuizPattern10 : TriggerState {
            internal StateMelodyQuizPattern10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "PatternPick", value: 110);
                context.SetUserValue(triggerId: 110, key: "PatternPick", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "AnswerIsRight") == 1) {
                    return new StateEndMelodyQuiz_Success(context);
                }

                if (context.GetUserValue(key: "AnswerIsWrong") == 1) {
                    return new StateEndMelodyQuiz_Fail(context);
                }

                if (context.TimeExpired(timerId: "1")) {
                    return new StateMelodyQuiz_Fail_Quit(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetUserValue(triggerId: 110, key: "Reset", value: 1);
            }
        }

        private class StateMelodyQuizPattern11 : TriggerState {
            internal StateMelodyQuizPattern11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "PatternPick", value: 111);
                context.SetUserValue(triggerId: 111, key: "PatternPick", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "AnswerIsRight") == 1) {
                    return new StateEndMelodyQuiz_Success(context);
                }

                if (context.GetUserValue(key: "AnswerIsWrong") == 1) {
                    return new StateEndMelodyQuiz_Fail(context);
                }

                if (context.TimeExpired(timerId: "1")) {
                    return new StateMelodyQuiz_Fail_Quit(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetUserValue(triggerId: 111, key: "Reset", value: 1);
            }
        }

        private class StateMelodyQuizPattern12 : TriggerState {
            internal StateMelodyQuizPattern12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "PatternPick", value: 112);
                context.SetUserValue(triggerId: 112, key: "PatternPick", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "AnswerIsRight") == 1) {
                    return new StateEndMelodyQuiz_Success(context);
                }

                if (context.GetUserValue(key: "AnswerIsWrong") == 1) {
                    return new StateEndMelodyQuiz_Fail(context);
                }

                if (context.TimeExpired(timerId: "1")) {
                    return new StateMelodyQuiz_Fail_Quit(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetUserValue(triggerId: 112, key: "Reset", value: 1);
            }
        }

        private class StateMelodyQuizPattern13 : TriggerState {
            internal StateMelodyQuizPattern13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "PatternPick", value: 113);
                context.SetUserValue(triggerId: 113, key: "PatternPick", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "AnswerIsRight") == 1) {
                    return new StateEndMelodyQuiz_Success(context);
                }

                if (context.GetUserValue(key: "AnswerIsWrong") == 1) {
                    return new StateEndMelodyQuiz_Fail(context);
                }

                if (context.TimeExpired(timerId: "1")) {
                    return new StateMelodyQuiz_Fail_Quit(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetUserValue(triggerId: 113, key: "Reset", value: 1);
            }
        }

        private class StateMelodyQuizPattern14 : TriggerState {
            internal StateMelodyQuizPattern14(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "PatternPick", value: 114);
                context.SetUserValue(triggerId: 114, key: "PatternPick", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "AnswerIsRight") == 1) {
                    return new StateEndMelodyQuiz_Success(context);
                }

                if (context.GetUserValue(key: "AnswerIsWrong") == 1) {
                    return new StateEndMelodyQuiz_Fail(context);
                }

                if (context.TimeExpired(timerId: "1")) {
                    return new StateMelodyQuiz_Fail_Quit(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetUserValue(triggerId: 114, key: "Reset", value: 1);
            }
        }

        private class StateMelodyQuizPattern15 : TriggerState {
            internal StateMelodyQuizPattern15(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "PatternPick", value: 115);
                context.SetUserValue(triggerId: 115, key: "PatternPick", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "AnswerIsRight") == 1) {
                    return new StateEndMelodyQuiz_Success(context);
                }

                if (context.GetUserValue(key: "AnswerIsWrong") == 1) {
                    return new StateEndMelodyQuiz_Fail(context);
                }

                if (context.TimeExpired(timerId: "1")) {
                    return new StateMelodyQuiz_Fail_Quit(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetUserValue(triggerId: 115, key: "Reset", value: 1);
            }
        }

        private class StateMelodyQuizPattern16 : TriggerState {
            internal StateMelodyQuizPattern16(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "PatternPick", value: 116);
                context.SetUserValue(triggerId: 116, key: "PatternPick", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "AnswerIsRight") == 1) {
                    return new StateEndMelodyQuiz_Success(context);
                }

                if (context.GetUserValue(key: "AnswerIsWrong") == 1) {
                    return new StateEndMelodyQuiz_Fail(context);
                }

                if (context.TimeExpired(timerId: "1")) {
                    return new StateMelodyQuiz_Fail_Quit(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetUserValue(triggerId: 116, key: "Reset", value: 1);
            }
        }

        private class StateMelodyQuizPattern17 : TriggerState {
            internal StateMelodyQuizPattern17(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "PatternPick", value: 117);
                context.SetUserValue(triggerId: 117, key: "PatternPick", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "AnswerIsRight") == 1) {
                    return new StateEndMelodyQuiz_Success(context);
                }

                if (context.GetUserValue(key: "AnswerIsWrong") == 1) {
                    return new StateEndMelodyQuiz_Fail(context);
                }

                if (context.TimeExpired(timerId: "1")) {
                    return new StateMelodyQuiz_Fail_Quit(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetUserValue(triggerId: 117, key: "Reset", value: 1);
            }
        }

        private class StateMelodyQuizPattern18 : TriggerState {
            internal StateMelodyQuizPattern18(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "PatternPick", value: 118);
                context.SetUserValue(triggerId: 118, key: "PatternPick", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "AnswerIsRight") == 1) {
                    return new StateEndMelodyQuiz_Success(context);
                }

                if (context.GetUserValue(key: "AnswerIsWrong") == 1) {
                    return new StateEndMelodyQuiz_Fail(context);
                }

                if (context.TimeExpired(timerId: "1")) {
                    return new StateMelodyQuiz_Fail_Quit(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetUserValue(triggerId: 118, key: "Reset", value: 1);
            }
        }

        private class StateMelodyQuizPattern19 : TriggerState {
            internal StateMelodyQuizPattern19(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "PatternPick", value: 119);
                context.SetUserValue(triggerId: 119, key: "PatternPick", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "AnswerIsRight") == 1) {
                    return new StateEndMelodyQuiz_Success(context);
                }

                if (context.GetUserValue(key: "AnswerIsWrong") == 1) {
                    return new StateEndMelodyQuiz_Fail(context);
                }

                if (context.TimeExpired(timerId: "1")) {
                    return new StateMelodyQuiz_Fail_Quit(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetUserValue(triggerId: 119, key: "Reset", value: 1);
            }
        }

        private class StateMelodyQuizPattern20 : TriggerState {
            internal StateMelodyQuizPattern20(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "PatternPick", value: 120);
                context.SetUserValue(triggerId: 120, key: "PatternPick", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "AnswerIsRight") == 1) {
                    return new StateEndMelodyQuiz_Success(context);
                }

                if (context.GetUserValue(key: "AnswerIsWrong") == 1) {
                    return new StateEndMelodyQuiz_Fail(context);
                }

                if (context.TimeExpired(timerId: "1")) {
                    return new StateMelodyQuiz_Fail_Quit(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetUserValue(triggerId: 120, key: "Reset", value: 1);
            }
        }

        private class StateEndMelodyQuiz_Success : TriggerState {
            internal StateEndMelodyQuiz_Success(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(boxIds: new []{11901}, skillId: 71001012, level: 1, arg4: false, arg5: false);
                context.SetEffect(triggerIds: new []{11300}, visible: true);
                context.SetInteractObject(interactIds: new []{12000203}, state: 1);
                context.SetTimer(timerId: "2", seconds: 60, autoRemove: true, display: false, vOffset: 0);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{12000203}, arg2: 0)) {
                    return new StateMelodyQuiz_Success_Quit(context);
                }

                if (context.TimeExpired(timerId: "2")) {
                    return new StateMelodyQuiz_Success_Quit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEndMelodyQuiz_Fail : TriggerState {
            internal StateEndMelodyQuiz_Fail(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{11302}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "TimeEventOn") == 0) {
                    return new StateEndMelodyQuiz_Fail_2(context);
                }

                if (context.TimeExpired(timerId: "1")) {
                    return new StateMelodyQuiz_Fail_Quit(context);
                }

                if (context.WaitTick(waitTick: 2000)) {
                    return new StateMelodyQuiz_Retry(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEndMelodyQuiz_Fail_2 : TriggerState {
            internal StateEndMelodyQuiz_Fail_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateWait(context);
                }

                if (context.WaitTick(waitTick: 2000)) {
                    return new StateMelodyQuiz_Retry(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMelodyQuiz_Retry : TriggerState {
            internal StateMelodyQuiz_Retry(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "AnswerIsWrong", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "PatternPick") == 101) {
                    return new StateMelodyQuizPattern01(context);
                }

                if (context.GetUserValue(key: "PatternPick") == 102) {
                    return new StateMelodyQuizPattern02(context);
                }

                if (context.GetUserValue(key: "PatternPick") == 103) {
                    return new StateMelodyQuizPattern03(context);
                }

                if (context.GetUserValue(key: "PatternPick") == 104) {
                    return new StateMelodyQuizPattern04(context);
                }

                if (context.GetUserValue(key: "PatternPick") == 105) {
                    return new StateMelodyQuizPattern05(context);
                }

                if (context.GetUserValue(key: "PatternPick") == 106) {
                    return new StateMelodyQuizPattern06(context);
                }

                if (context.GetUserValue(key: "PatternPick") == 107) {
                    return new StateMelodyQuizPattern07(context);
                }

                if (context.GetUserValue(key: "PatternPick") == 108) {
                    return new StateMelodyQuizPattern08(context);
                }

                if (context.GetUserValue(key: "PatternPick") == 109) {
                    return new StateMelodyQuizPattern09(context);
                }

                if (context.GetUserValue(key: "PatternPick") == 110) {
                    return new StateMelodyQuizPattern10(context);
                }

                if (context.GetUserValue(key: "PatternPick") == 111) {
                    return new StateMelodyQuizPattern11(context);
                }

                if (context.GetUserValue(key: "PatternPick") == 112) {
                    return new StateMelodyQuizPattern12(context);
                }

                if (context.GetUserValue(key: "PatternPick") == 113) {
                    return new StateMelodyQuizPattern13(context);
                }

                if (context.GetUserValue(key: "PatternPick") == 114) {
                    return new StateMelodyQuizPattern14(context);
                }

                if (context.GetUserValue(key: "PatternPick") == 115) {
                    return new StateMelodyQuizPattern15(context);
                }

                if (context.GetUserValue(key: "PatternPick") == 116) {
                    return new StateMelodyQuizPattern16(context);
                }

                if (context.GetUserValue(key: "PatternPick") == 117) {
                    return new StateMelodyQuizPattern17(context);
                }

                if (context.GetUserValue(key: "PatternPick") == 118) {
                    return new StateMelodyQuizPattern18(context);
                }

                if (context.GetUserValue(key: "PatternPick") == 119) {
                    return new StateMelodyQuizPattern19(context);
                }

                if (context.GetUserValue(key: "PatternPick") == 120) {
                    return new StateMelodyQuizPattern20(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMelodyQuiz_Fail_Quit : TriggerState {
            internal StateMelodyQuiz_Fail_Quit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ResetTimer(timerId: "1");
                context.ResetTimer(timerId: "2");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMelodyQuiz_Success_Quit : TriggerState {
            internal StateMelodyQuiz_Success_Quit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "TimeEventOn", value: 0);
                context.ResetTimer(timerId: "1");
                context.ResetTimer(timerId: "2");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
