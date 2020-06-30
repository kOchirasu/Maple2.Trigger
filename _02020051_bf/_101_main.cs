using System;
using System.Numerics;

namespace Maple2.Trigger._02020051_bf {
    public static class _101_main {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State준비(context);

        private class State준비 : TriggerState {
            internal State준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State포션사용(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State포션사용 : TriggerState {
            internal State포션사용(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(arg1: 60001, arg2: false);
                context.ResetTimer(arg1: "999");
                context.SetUserValue(triggerID: 102, key: "Timmer", value: 2);
                context.SetAmbientLight(arg1: new Vector3(198f, 255f, 205f));
                context.SetDirectionalLight(arg1: new Vector3(255f, 234f, 193f), arg2: new Vector3(255f, 255f, 255f));
                context.SetUserValue(triggerID: 104, key: "End", value: 2);
                context.SetUserValue(triggerID: 103, key: "Main", value: 1);
            }

            public override void Execute() {
                if (context.UserValue(key: "Potion", value: 1)) {
                    context.State = new State타이머(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State타이머 : TriggerState {
            internal State타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "999", arg2: 10, arg3: true, arg4: true);
                context.SideNpcTalk(type: "talk", npcID: 11003536, illust: "Neirin_surprise",
                    script: "$02020051_BF__101_MAIN__0$", duration: 5684, voice: @"ko/Npc/00002201");
                context.RemoveBuff(arg1: 11, arg2: 90000900);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new State페이드아웃(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State페이드아웃 : TriggerState {
            internal State페이드아웃(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ResetTimer(arg1: "999");
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetAmbientLight(arg1: new Vector3(102f, 86f, 112f));
                    context.SetDirectionalLight(arg1: new Vector3(255f, 234f, 193f), arg2: new Vector3(127f, 91f, 93f));
                    context.State = new State페이드인(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State페이드인 : TriggerState {
            internal State페이드인(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SideNpcTalk(type: "talk", npcID: 11003536, illust: "Neirin_surprise",
                    script: "$02020051_BF__101_MAIN__1$", duration: 5684, voice: @"ko/Npc/00002201");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State기간티카등장_렌덤조건(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State기간티카등장_렌덤조건 : TriggerState {
            internal State기간티카등장_렌덤조건(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(arg1: 60001, arg2: true);
            }

            public override void Execute() {
                if (context.RandomCondition(arg1: 20f)) {
                    context.State = new State기간티카등장_1(context);
                    return;
                }

                if (context.RandomCondition(arg1: 20f)) {
                    context.State = new State기간티카등장_2(context);
                    return;
                }

                if (context.RandomCondition(arg1: 20f)) {
                    context.State = new State기간티카등장_3(context);
                    return;
                }

                if (context.RandomCondition(arg1: 20f)) {
                    context.State = new State기간티카등장_4(context);
                    return;
                }

                if (context.RandomCondition(arg1: 20f)) {
                    context.State = new State기간티카등장_5(context);
                    return;
                }

                if (context.RandomCondition(arg1: 20f)) {
                    context.State = new State기간티카등장_6(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State기간티카등장_1 : TriggerState {
            internal State기간티카등장_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {1001}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State기간티카등장_2 : TriggerState {
            internal State기간티카등장_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {1002}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State기간티카등장_3 : TriggerState {
            internal State기간티카등장_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {1003}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State기간티카등장_4 : TriggerState {
            internal State기간티카등장_4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {1004}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State기간티카등장_5 : TriggerState {
            internal State기간티카등장_5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {1005}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State기간티카등장_6 : TriggerState {
            internal State기간티카등장_6(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {1006}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 105, key: "Summon_monster", value: 1);
                context.SetUserValue(triggerID: 106, key: "Summon_monster_2", value: 1);
                context.SetUserValue(triggerID: 102, key: "Timmer", value: 1);
                context.SetUserValue(triggerID: 104, key: "End", value: 1);
                context.SetEventUI(arg1: 1, arg2: "$02020051_BF__101_MAIN__2$", arg3: new int[] {4000});
            }

            public override void Execute() {
                if (context.UserValue(key: "Potion", value: 2)) {
                    context.State = new State포션사용(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}