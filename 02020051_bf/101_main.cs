using System.Numerics;
using Maple2.Trigger.Enum;

namespace Maple2.Trigger._02020051_bf {
    public static class _101_main {
        public class StateSetup : TriggerState {
            internal StateSetup(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State포션사용(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State포션사용 : TriggerState {
            internal State포션사용(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(arg1: 60001, arg2: false);
                context.ResetTimer(id: "999");
                context.SetUserValue(triggerId: 102, key: "Timmer", value: 2);
                context.SetAmbientLight(arg1: new Vector3(198f, 255f, 205f));
                context.SetDirectionalLight(arg1: new Vector3(255f, 234f, 193f), arg2: new Vector3(255f, 255f, 255f));
                context.SetUserValue(triggerId: 104, key: "End", value: 2);
                context.SetUserValue(triggerId: 103, key: "Main", value: 1);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Potion") == 1) {
                    return new State타이머(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State타이머 : TriggerState {
            internal State타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "999", arg2: 10, arg3: true, arg4: true);
                context.SideNpcTalk(type: SideNpcTalkType.Talk, npcId: 11003536, illust: "Neirin_surprise", script: "$02020051_BF__101_MAIN__0$", duration: 5684, voice: @"ko/Npc/00002201");
                context.RemoveBuff(arg1: 11, arg2: 90000900);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateFadeOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFadeOut : TriggerState {
            internal StateFadeOut(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ResetTimer(id: "999");
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetAmbientLight(arg1: new Vector3(102f, 86f, 112f));
                    context.SetDirectionalLight(arg1: new Vector3(255f, 234f, 193f), arg2: new Vector3(127f, 91f, 93f));
                    return new StateFadeIn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFadeIn : TriggerState {
            internal StateFadeIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SideNpcTalk(type: SideNpcTalkType.Talk, npcId: 11003536, illust: "Neirin_surprise", script: "$02020051_BF__101_MAIN__1$", duration: 5684, voice: @"ko/Npc/00002201");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State기간티카Spawn_렌덤조건(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State기간티카Spawn_렌덤조건 : TriggerState {
            internal State기간티카Spawn_렌덤조건(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(arg1: 60001, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.RandomCondition(arg1: 20f)) {
                    return new State기간티카Spawn_1(context);
                }

                if (context.RandomCondition(arg1: 20f)) {
                    return new State기간티카Spawn_2(context);
                }

                if (context.RandomCondition(arg1: 20f)) {
                    return new State기간티카Spawn_3(context);
                }

                if (context.RandomCondition(arg1: 20f)) {
                    return new State기간티카Spawn_4(context);
                }

                if (context.RandomCondition(arg1: 20f)) {
                    return new State기간티카Spawn_5(context);
                }

                if (context.RandomCondition(arg1: 20f)) {
                    return new State기간티카Spawn_6(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State기간티카Spawn_1 : TriggerState {
            internal State기간티카Spawn_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1001}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State기간티카Spawn_2 : TriggerState {
            internal State기간티카Spawn_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1002}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State기간티카Spawn_3 : TriggerState {
            internal State기간티카Spawn_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1003}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State기간티카Spawn_4 : TriggerState {
            internal State기간티카Spawn_4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1004}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State기간티카Spawn_5 : TriggerState {
            internal State기간티카Spawn_5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1005}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State기간티카Spawn_6 : TriggerState {
            internal State기간티카Spawn_6(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1006}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 105, key: "Summon_monster", value: 1);
                context.SetUserValue(triggerId: 106, key: "Summon_monster_2", value: 1);
                context.SetUserValue(triggerId: 102, key: "Timmer", value: 1);
                context.SetUserValue(triggerId: 104, key: "End", value: 1);
                context.SetEventUI(arg1: 1, script: "$02020051_BF__101_MAIN__2$", arg3: 4000);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Potion") == 2) {
                    return new State포션사용(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}