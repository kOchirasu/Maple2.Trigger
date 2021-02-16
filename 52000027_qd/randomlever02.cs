namespace Maple2.Trigger._52000027_qd {
    public static class _randomlever02 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000475, 10000476, 10000477}, arg2: 0);
            }

            public override TriggerState Execute() {
                if (context.RandomCondition(arg1: 30f)) {
                    return new State1Pattern(context);
                }

                if (context.RandomCondition(arg1: 30f)) {
                    return new State2Pattern(context);
                }

                if (context.RandomCondition(arg1: 30f)) {
                    return new State3Pattern(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1Pattern : TriggerState {
            internal State1Pattern(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "SetLever") == 1) {
                    return new State1Pattern_모든레버켜기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1Pattern_모든레버켜기 : TriggerState {
            internal State1Pattern_모든레버켜기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000475, 10000476, 10000477}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000475}, arg2: 0)) {
                    return new State1Pattern_정답(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000476}, arg2: 0)) {
                    return new State1Pattern_2번레버_오답01(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000477}, arg2: 0)) {
                    return new State1Pattern_3번레버_오답01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1Pattern_정답 : TriggerState {
            internal State1Pattern_정답(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000476, 10000477}, arg2: 0);
                context.SetUserValue(triggerId: 1, key: "TrapOpen", value: 1);
                context.SetUserValue(triggerId: 3, key: "TrapOpen", value: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1Pattern_2번레버_오답01 : TriggerState {
            internal State1Pattern_2번레버_오답01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 102, script: "$52000027_QD__RANDOMLEVER02__0$", arg4: 3, arg5: 0);
                context.SetInteractObject(arg1: new[] {10000475, 10000477}, arg2: 0);
                context.CreateMonster(arg1: new[] {921}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {921})) {
                    return new State1Pattern_2번레버_재도전(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1Pattern_2번레버_재도전 : TriggerState {
            internal State1Pattern_2번레버_재도전(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000475, 10000477}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000475}, arg2: 0)) {
                    return new State1Pattern_정답(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000477}, arg2: 0)) {
                    return new State1Pattern_2번레버_오답02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1Pattern_2번레버_오답02 : TriggerState {
            internal State1Pattern_2번레버_오답02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 102, script: "$52000027_QD__RANDOMLEVER02__1$", arg4: 3, arg5: 0);
                context.SetInteractObject(arg1: new[] {10000475}, arg2: 0);
                context.CreateMonster(arg1: new[] {922}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {921})) {
                    return new State1Pattern_2번레버_마지막도전(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1Pattern_2번레버_마지막도전 : TriggerState {
            internal State1Pattern_2번레버_마지막도전(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000475}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000475}, arg2: 0)) {
                    return new State1Pattern_정답(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1Pattern_3번레버_오답01 : TriggerState {
            internal State1Pattern_3번레버_오답01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 102, script: "$52000027_QD__RANDOMLEVER02__0$", arg4: 3, arg5: 0);
                context.SetInteractObject(arg1: new[] {10000475, 10000476}, arg2: 0);
                context.CreateMonster(arg1: new[] {921}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {921})) {
                    return new State1Pattern_3번레버_재도전(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1Pattern_3번레버_재도전 : TriggerState {
            internal State1Pattern_3번레버_재도전(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000475, 10000476}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000475}, arg2: 0)) {
                    return new State1Pattern_정답(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000476}, arg2: 0)) {
                    return new State1Pattern_3번레버_오답02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1Pattern_3번레버_오답02 : TriggerState {
            internal State1Pattern_3번레버_오답02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 102, script: "$52000027_QD__RANDOMLEVER02__1$", arg4: 3, arg5: 0);
                context.SetInteractObject(arg1: new[] {10000475}, arg2: 0);
                context.CreateMonster(arg1: new[] {922}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {921})) {
                    return new State1Pattern_3번레버_마지막도전(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1Pattern_3번레버_마지막도전 : TriggerState {
            internal State1Pattern_3번레버_마지막도전(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000475}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000475}, arg2: 0)) {
                    return new State1Pattern_정답(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2Pattern : TriggerState {
            internal State2Pattern(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "SetLever") == 1) {
                    return new State2Pattern_모든레버켜기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2Pattern_모든레버켜기 : TriggerState {
            internal State2Pattern_모든레버켜기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000475, 10000476, 10000477}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000475}, arg2: 0)) {
                    return new State2Pattern_1번레버_오답01(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000476}, arg2: 0)) {
                    return new State2Pattern_정답(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000477}, arg2: 0)) {
                    return new State2Pattern_3번레버_오답01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2Pattern_정답 : TriggerState {
            internal State2Pattern_정답(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000475, 10000477}, arg2: 0);
                context.SetUserValue(triggerId: 1, key: "TrapOpen", value: 1);
                context.SetUserValue(triggerId: 3, key: "TrapOpen", value: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2Pattern_1번레버_오답01 : TriggerState {
            internal State2Pattern_1번레버_오답01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 102, script: "$52000027_QD__RANDOMLEVER02__0$", arg4: 3, arg5: 0);
                context.SetInteractObject(arg1: new[] {10000476, 10000477}, arg2: 0);
                context.CreateMonster(arg1: new[] {921}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {921})) {
                    return new State2Pattern_1번레버_재도전(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2Pattern_1번레버_재도전 : TriggerState {
            internal State2Pattern_1번레버_재도전(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000476, 10000477}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000476}, arg2: 0)) {
                    return new State2Pattern_정답(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000477}, arg2: 0)) {
                    return new State2Pattern_1번레버_오답02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2Pattern_1번레버_오답02 : TriggerState {
            internal State2Pattern_1번레버_오답02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 102, script: "$52000027_QD__RANDOMLEVER02__1$", arg4: 3, arg5: 0);
                context.SetInteractObject(arg1: new[] {10000476}, arg2: 0);
                context.CreateMonster(arg1: new[] {922}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {921})) {
                    return new State2Pattern_1번레버_마지막도전(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2Pattern_1번레버_마지막도전 : TriggerState {
            internal State2Pattern_1번레버_마지막도전(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000476}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000476}, arg2: 0)) {
                    return new State2Pattern_정답(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2Pattern_3번레버_오답01 : TriggerState {
            internal State2Pattern_3번레버_오답01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 102, script: "$52000027_QD__RANDOMLEVER02__0$", arg4: 3, arg5: 0);
                context.SetInteractObject(arg1: new[] {10000476, 10000477}, arg2: 0);
                context.CreateMonster(arg1: new[] {921}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {921})) {
                    return new State2Pattern_3번레버_재도전(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2Pattern_3번레버_재도전 : TriggerState {
            internal State2Pattern_3번레버_재도전(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000476, 10000477}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000476}, arg2: 0)) {
                    return new State2Pattern_정답(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000477}, arg2: 0)) {
                    return new State2Pattern_3번레버_오답02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2Pattern_3번레버_오답02 : TriggerState {
            internal State2Pattern_3번레버_오답02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 102, script: "$52000027_QD__RANDOMLEVER02__1$", arg4: 3, arg5: 0);
                context.SetInteractObject(arg1: new[] {10000476}, arg2: 0);
                context.CreateMonster(arg1: new[] {922}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {921})) {
                    return new State2Pattern_3번레버_마지막도전(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2Pattern_3번레버_마지막도전 : TriggerState {
            internal State2Pattern_3번레버_마지막도전(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000476}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000476}, arg2: 0)) {
                    return new State2Pattern_정답(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3Pattern : TriggerState {
            internal State3Pattern(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "SetLever") == 1) {
                    return new State3Pattern_모든레버켜기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3Pattern_모든레버켜기 : TriggerState {
            internal State3Pattern_모든레버켜기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000475, 10000476, 10000477}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000475}, arg2: 0)) {
                    return new State3Pattern_1번레버_오답01(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000476}, arg2: 0)) {
                    return new State3Pattern_2번레버_오답01(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000477}, arg2: 0)) {
                    return new State3Pattern_정답(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3Pattern_정답 : TriggerState {
            internal State3Pattern_정답(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000475, 10000476}, arg2: 0);
                context.SetUserValue(triggerId: 1, key: "TrapOpen", value: 1);
                context.SetUserValue(triggerId: 3, key: "TrapOpen", value: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3Pattern_1번레버_오답01 : TriggerState {
            internal State3Pattern_1번레버_오답01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 102, script: "$52000027_QD__RANDOMLEVER02__0$", arg4: 3, arg5: 0);
                context.SetInteractObject(arg1: new[] {10000476, 10000477}, arg2: 0);
                context.CreateMonster(arg1: new[] {921}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {921})) {
                    return new State3Pattern_1번레버_재도전(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3Pattern_1번레버_재도전 : TriggerState {
            internal State3Pattern_1번레버_재도전(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000476, 10000477}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000476}, arg2: 0)) {
                    return new State3Pattern_1번레버_오답02(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000477}, arg2: 0)) {
                    return new State3Pattern_정답(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3Pattern_1번레버_오답02 : TriggerState {
            internal State3Pattern_1번레버_오답02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 102, script: "$52000027_QD__RANDOMLEVER02__1$", arg4: 3, arg5: 0);
                context.SetInteractObject(arg1: new[] {10000477}, arg2: 0);
                context.CreateMonster(arg1: new[] {922}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {921})) {
                    return new State3Pattern_1번레버_마지막도전(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3Pattern_1번레버_마지막도전 : TriggerState {
            internal State3Pattern_1번레버_마지막도전(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000477}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000477}, arg2: 0)) {
                    return new State3Pattern_정답(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3Pattern_2번레버_오답01 : TriggerState {
            internal State3Pattern_2번레버_오답01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 102, script: "$52000027_QD__RANDOMLEVER02__0$", arg4: 3, arg5: 0);
                context.SetInteractObject(arg1: new[] {10000475, 10000477}, arg2: 0);
                context.CreateMonster(arg1: new[] {921}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {921})) {
                    return new State3Pattern_2번레버_재도전(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3Pattern_2번레버_재도전 : TriggerState {
            internal State3Pattern_2번레버_재도전(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000475, 10000477}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000475}, arg2: 0)) {
                    return new State3Pattern_2번레버_오답02(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000477}, arg2: 0)) {
                    return new State3Pattern_정답(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3Pattern_2번레버_오답02 : TriggerState {
            internal State3Pattern_2번레버_오답02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 102, script: "$52000027_QD__RANDOMLEVER02__1$", arg4: 3, arg5: 0);
                context.SetInteractObject(arg1: new[] {10000477}, arg2: 0);
                context.CreateMonster(arg1: new[] {922}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {921})) {
                    return new State3Pattern_2번레버_마지막도전(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3Pattern_2번레버_마지막도전 : TriggerState {
            internal State3Pattern_2번레버_마지막도전(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000477}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000477}, arg2: 0)) {
                    return new State3Pattern_정답(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}