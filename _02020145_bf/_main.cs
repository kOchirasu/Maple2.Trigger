using System.Numerics;

namespace Maple2.Trigger._02020145_bf {
    public static class _main {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAmbientLight(arg1: new Vector3(183f, 189f, 201f));
                context.SetDirectionalLight(arg1: new Vector3(192f, 210f, 211f), arg2: new Vector3(170f, 170f, 170f));
                context.SetEffect(arg1: new[] {200031, 200032, 200033, 200034, 200035}, arg2: false);
                context.SetEffect(arg1: new[] {200001, 200002, 200003, 200004, 200005}, arg2: false);
                context.SetEffect(arg1: new[] {200021, 200022, 200023, 200024, 200025}, arg2: false);
                context.SetEffect(arg1: new[] {200011, 200012, 200013, 200014, 200015}, arg2: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {1007})) {
                    context.State = new State시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveBuff(arg1: 1006, arg2: 70002151, arg3: true);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {1007})) {
                    context.State = new State보스전_시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스전_시작 : TriggerState {
            internal State보스전_시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: "talk", npcId: 23501011, illust: "Turned_Renduebian_normal",
                    script: "$02020111_BF__MAIN__0$", duration: 5684, voice: @"ko/Npc/00002201");
                context.CreateMonster(arg1: new[] {101});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5684)) {
                    context.State = new State조명변경(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State조명변경 : TriggerState {
            internal State조명변경(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAmbientLight(arg1: new Vector3(52f, 48f, 38f));
                context.SetDirectionalLight(arg1: new Vector3(0f, 0f, 0f), arg2: new Vector3(206f, 174f, 84f));
                context.AddBuff(arg1: new[] {101}, arg2: 62100014, arg3: 1, arg4: true);
                context.AddBuff(arg1: new[] {1001}, arg2: 75000001, arg3: 1);
                context.CreateMonster(arg1: new[] {121, 123, 125, 131, 132, 133});
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {101})) {
                    context.State = new State보스전_성공(context);
                    return;
                }

                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new State페이드인(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State페이드인 : TriggerState {
            internal State페이드인(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.NpcRemoveAdditionalEffect(spawnPointId: 101, additionalEffectId: 62100014);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State조명리셋(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State조명리셋 : TriggerState {
            internal State조명리셋(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 101, arg3: "$02020111_BF__MOVEMENT_01__1$", arg4: 3, arg5: 0);
                context.DestroyMonster(arg1: new[] {121, 122, 123, 124, 125, 131, 132, 133, 134});
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetAmbientLight(arg1: new Vector3(183f, 189f, 201f));
                context.SetDirectionalLight(arg1: new Vector3(192f, 210f, 211f), arg2: new Vector3(170f, 170f, 170f));
                context.AddBuff(arg1: new[] {1001}, arg2: 75000002, arg3: 1);
                context.AddBuff(arg1: new[] {1002}, arg2: 75000002, arg3: 1);
                context.AddBuff(arg1: new[] {1003}, arg2: 75000002, arg3: 1);
                context.AddBuff(arg1: new[] {1004}, arg2: 75000002, arg3: 1);
                context.AddBuff(arg1: new[] {1005}, arg2: 75000002, arg3: 1);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {101})) {
                    context.State = new State보스전_성공(context);
                    return;
                }

                if (context.WaitTick(waitTick: 15000)) {
                    context.State = new State조건확인(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State조건확인 : TriggerState {
            internal State조건확인(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {101})) {
                    context.State = new State보스전_성공(context);
                    return;
                }

                if (context.GetNpcHpRate(spawnPointId: 101) >= 0.50f) {
                    context.State = new State조명변경(context);
                    return;
                }

                if (context.GetNpcHpRate(spawnPointId: 101) <= 0.50f) {
                    context.State = new State조건추가(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State조건추가 : TriggerState {
            internal State조건추가(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {101})) {
                    context.State = new State보스전_성공(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스전_성공 : TriggerState {
            internal State보스전_성공(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg2: "trigger", arg3: "ClearBlueLapenta_Quest");
                context.SideNpcTalk(type: "talk", npcId: 23501011, illust: "Turned_Renduebian_normal",
                    script: "$02020111_BF__MAIN__1$", duration: 3176, voice: @"ko/Npc/00002202");
                context.DestroyMonster(arg1: new[] {121, 122, 123, 124, 125, 131, 132, 133, 134});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3176)) {
                    context.State = new State조명리셋2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State조명리셋2 : TriggerState {
            internal State조명리셋2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAmbientLight(arg1: new Vector3(183f, 189f, 201f));
                context.SetDirectionalLight(arg1: new Vector3(192f, 210f, 211f), arg2: new Vector3(170f, 170f, 170f));
                context.AddBuff(arg1: new[] {1001}, arg2: 75000002, arg3: 1);
                context.AddBuff(arg1: new[] {1002}, arg2: 75000002, arg3: 1);
                context.AddBuff(arg1: new[] {1003}, arg2: 75000002, arg3: 1);
                context.AddBuff(arg1: new[] {1004}, arg2: 75000002, arg3: 1);
                context.AddBuff(arg1: new[] {1005}, arg2: 75000002, arg3: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {-1});
                context.SetAchievement(arg2: "trigger", arg3: "ClearBlueLapenta_Quest");
                context.SetPortal(arg1: 4, arg2: true, arg3: true, arg4: true);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}