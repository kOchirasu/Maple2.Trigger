using System;
using Maple2.Trigger._dungeon_common;

namespace Maple2.Trigger._02000252_bf {
    public static class _start {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {151, 152, 153, 154, 155, 156}, arg2: true);
                context.SetEffect(arg1: new int[] {601}, arg2: false);
                context.SetEffect(arg1: new int[] {602}, arg2: false);
                context.SetEffect(arg1: new int[] {603}, arg2: false);
                context.SetEffect(arg1: new int[] {8001}, arg2: false);
                context.SetEffect(arg1: new int[] {8002}, arg2: false);
                context.SetEffect(arg1: new int[] {8003}, arg2: false);
                context.SetEffect(arg1: new int[] {8004}, arg2: false);
                context.SetEffect(arg1: new int[] {8005}, arg2: false);
                context.SetEffect(arg1: new int[] {8006}, arg2: false);
                context.SetEffect(arg1: new int[] {8007}, arg2: false);
                context.SetEffect(arg1: new int[] {8008}, arg2: false);
                context.SetEffect(arg1: new int[] {8009}, arg2: false);
                context.SetEffect(arg1: new int[] {8010}, arg2: false);
                context.SetEffect(arg1: new int[] {8011}, arg2: false);
                context.SetEffect(arg1: new int[] {8012}, arg2: false);
            }

            public override void Execute() {
                if (context.CheckUser()) {
                    context.State = new State로딩딜레이(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State로딩딜레이 : TriggerState {
            internal State로딩딜레이(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State =
                        new _checkusercount.StateCheckUserCount(context, new StateDungeonStart(context));
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDungeonStart : TriggerState {
            internal StateDungeonStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityID: 20002521);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State벨라소환(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출해제 : TriggerState {
            internal State연출해제(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State벨라소환(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State벨라소환 : TriggerState {
            internal State벨라소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelectPath(arg1: new int[] {8801, 8802}, arg2: false);
                context.CreateMonster(arg1: new int[] {1001});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State벨라대사(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State벨라대사 : TriggerState {
            internal State벨라대사(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(arg1: "벨라스킬딜레이", arg2: "nextState");
                context.SetSkip(arg1: "벨라스킬딜레이");
                context.SetTimer(arg1: "1", arg2: 6);
                context.SetConversation(arg1: 2, arg2: 11000057, arg3: "$02000252_BF__START__4$", arg4: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State벨라대사2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State벨라대사2 : TriggerState {
            internal State벨라대사2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 8);
                context.SetConversation(arg1: 2, arg2: 11000057, arg3: "$02000252_BF__START__5$", arg4: 4);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State벨라대사3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State벨라대사3 : TriggerState {
            internal State벨라대사3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 4);
                context.SetSceneSkip();
                context.SetConversation(arg1: 2, arg2: 11000057, arg3: "$02000252_BF__START__6$", arg4: 4);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6243)) {
                    context.State = new State벨라스킬딜레이(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State벨라스킬딜레이 : TriggerState {
            internal State벨라스킬딜레이(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 1001, arg2: "MS2PatrolData_1");
                context.SetTimer(arg1: "1", arg2: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new State예고이펙트(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State예고이펙트 : TriggerState {
            internal State예고이펙트(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8804}, arg2: true);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetAchievement(arg1: 999, arg2: "trigger", arg3: "Bellafirst");
                context.SetEffect(arg1: new int[] {8001}, arg2: true);
                context.SetEffect(arg1: new int[] {8002}, arg2: true);
                context.SetEffect(arg1: new int[] {8003}, arg2: true);
                context.SetEffect(arg1: new int[] {8004}, arg2: true);
                context.SetEffect(arg1: new int[] {8005}, arg2: true);
                context.SetEffect(arg1: new int[] {8006}, arg2: true);
                context.SetEffect(arg1: new int[] {8007}, arg2: true);
                context.SetEffect(arg1: new int[] {8008}, arg2: true);
                context.SetEffect(arg1: new int[] {8009}, arg2: true);
                context.SetEffect(arg1: new int[] {8010}, arg2: true);
                context.SetEffect(arg1: new int[] {8011}, arg2: true);
                context.SetEffect(arg1: new int[] {8012}, arg2: true);
                context.SetTimer(arg1: "2", arg2: 2);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    context.State = new State스킬시작대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬시작대기 : TriggerState {
            internal State스킬시작대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityID: 20002522, textID: 20002522);
                context.SetMesh(arg1: new int[] {151, 152, 153, 154, 155, 156}, arg2: false);
                context.CreateMonster(arg1: new int[] {1051}, arg2: false);
                context.CreateMonster(arg1: new int[] {1052}, arg2: false);
                context.CreateMonster(arg1: new int[] {1053}, arg2: false);
                context.CreateMonster(arg1: new int[] {1054}, arg2: false);
                context.CreateMonster(arg1: new int[] {1055}, arg2: false);
                context.CreateMonster(arg1: new int[] {1056}, arg2: false);
                context.CreateMonster(arg1: new int[] {1057}, arg2: false);
                context.CreateMonster(arg1: new int[] {1058}, arg2: false);
                context.CreateMonster(arg1: new int[] {1059}, arg2: false);
                context.CreateMonster(arg1: new int[] {1060}, arg2: false);
                context.CreateMonster(arg1: new int[] {1061}, arg2: false);
                context.CreateMonster(arg1: new int[] {1062}, arg2: false);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.DestroyMonster(arg1: new int[] {1001});
                    context.State = new State스킬시작대기2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬시작대기2 : TriggerState {
            internal State스킬시작대기2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "2", arg2: 2);
                context.SetEffect(arg1: new int[] {8001}, arg2: false);
                context.SetEffect(arg1: new int[] {8002}, arg2: false);
                context.SetEffect(arg1: new int[] {8003}, arg2: false);
                context.SetEffect(arg1: new int[] {8004}, arg2: false);
                context.SetEffect(arg1: new int[] {8005}, arg2: false);
                context.SetEffect(arg1: new int[] {8006}, arg2: false);
                context.SetEffect(arg1: new int[] {8007}, arg2: false);
                context.SetEffect(arg1: new int[] {8008}, arg2: false);
                context.SetEffect(arg1: new int[] {8009}, arg2: false);
                context.SetEffect(arg1: new int[] {8010}, arg2: false);
                context.SetEffect(arg1: new int[] {8011}, arg2: false);
                context.SetEffect(arg1: new int[] {8012}, arg2: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    context.State = new State스킬08(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬08 : TriggerState {
            internal State스킬08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new int[] {515}, arg2: true);
                context.SetSkill(arg1: new int[] {516}, arg2: true);
                context.SetSkill(arg1: new int[] {517}, arg2: true);
                context.SetSkill(arg1: new int[] {518}, arg2: true);
                context.SetSkill(arg1: new int[] {519}, arg2: true);
                context.SetSkill(arg1: new int[] {520}, arg2: true);
                context.SetSkill(arg1: new int[] {521}, arg2: true);
                context.SetSkill(arg1: new int[] {522}, arg2: true);
                context.SetSkill(arg1: new int[] {523}, arg2: true);
                context.SetSkill(arg1: new int[] {524}, arg2: true);
                context.SetSkill(arg1: new int[] {525}, arg2: true);
                context.SetSkill(arg1: new int[] {526}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬07대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬07대기 : TriggerState {
            internal State스킬07대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {515}, arg2: false);
                context.SetSkill(arg1: new int[] {516}, arg2: false);
                context.SetSkill(arg1: new int[] {517}, arg2: false);
                context.SetSkill(arg1: new int[] {518}, arg2: false);
                context.SetSkill(arg1: new int[] {519}, arg2: false);
                context.SetSkill(arg1: new int[] {520}, arg2: false);
                context.SetSkill(arg1: new int[] {521}, arg2: false);
                context.SetSkill(arg1: new int[] {522}, arg2: false);
                context.SetSkill(arg1: new int[] {523}, arg2: false);
                context.SetSkill(arg1: new int[] {524}, arg2: false);
                context.SetSkill(arg1: new int[] {525}, arg2: false);
                context.SetSkill(arg1: new int[] {526}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬07 : TriggerState {
            internal State스킬07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new int[] {564}, arg2: true);
                context.SetSkill(arg1: new int[] {517}, arg2: true);
                context.SetSkill(arg1: new int[] {518}, arg2: true);
                context.SetSkill(arg1: new int[] {519}, arg2: true);
                context.SetSkill(arg1: new int[] {520}, arg2: true);
                context.SetSkill(arg1: new int[] {521}, arg2: true);
                context.SetSkill(arg1: new int[] {522}, arg2: true);
                context.SetSkill(arg1: new int[] {523}, arg2: true);
                context.SetSkill(arg1: new int[] {524}, arg2: true);
                context.SetSkill(arg1: new int[] {525}, arg2: true);
                context.SetSkill(arg1: new int[] {526}, arg2: true);
                context.SetSkill(arg1: new int[] {527}, arg2: true);
                context.SetSkill(arg1: new int[] {528}, arg2: true);
                context.SetSkill(arg1: new int[] {529}, arg2: true);
                context.SetSkill(arg1: new int[] {530}, arg2: true);
                context.SetSkill(arg1: new int[] {531}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬06대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬06대기 : TriggerState {
            internal State스킬06대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {564}, arg2: false);
                context.SetSkill(arg1: new int[] {517}, arg2: false);
                context.SetSkill(arg1: new int[] {518}, arg2: false);
                context.SetSkill(arg1: new int[] {519}, arg2: false);
                context.SetSkill(arg1: new int[] {520}, arg2: false);
                context.SetSkill(arg1: new int[] {521}, arg2: false);
                context.SetSkill(arg1: new int[] {522}, arg2: false);
                context.SetSkill(arg1: new int[] {523}, arg2: false);
                context.SetSkill(arg1: new int[] {524}, arg2: false);
                context.SetSkill(arg1: new int[] {525}, arg2: false);
                context.SetSkill(arg1: new int[] {526}, arg2: false);
                context.SetSkill(arg1: new int[] {527}, arg2: false);
                context.SetSkill(arg1: new int[] {528}, arg2: false);
                context.SetSkill(arg1: new int[] {529}, arg2: false);
                context.SetSkill(arg1: new int[] {530}, arg2: false);
                context.SetSkill(arg1: new int[] {531}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬06 : TriggerState {
            internal State스킬06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new int[] {565}, arg2: true);
                context.SetSkill(arg1: new int[] {564}, arg2: true);
                context.SetSkill(arg1: new int[] {522}, arg2: true);
                context.SetSkill(arg1: new int[] {523}, arg2: true);
                context.SetSkill(arg1: new int[] {524}, arg2: true);
                context.SetSkill(arg1: new int[] {525}, arg2: true);
                context.SetSkill(arg1: new int[] {526}, arg2: true);
                context.SetSkill(arg1: new int[] {527}, arg2: true);
                context.SetSkill(arg1: new int[] {528}, arg2: true);
                context.SetSkill(arg1: new int[] {529}, arg2: true);
                context.SetSkill(arg1: new int[] {530}, arg2: true);
                context.SetSkill(arg1: new int[] {531}, arg2: true);
                context.SetSkill(arg1: new int[] {532}, arg2: true);
                context.SetSkill(arg1: new int[] {533}, arg2: true);
                context.SetSkill(arg1: new int[] {534}, arg2: true);
                context.SetSkill(arg1: new int[] {535}, arg2: true);
                context.SetSkill(arg1: new int[] {536}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬05대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬05대기 : TriggerState {
            internal State스킬05대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityID: 20002522);
                context.SetSkill(arg1: new int[] {565}, arg2: false);
                context.SetSkill(arg1: new int[] {564}, arg2: false);
                context.SetSkill(arg1: new int[] {522}, arg2: false);
                context.SetSkill(arg1: new int[] {523}, arg2: false);
                context.SetSkill(arg1: new int[] {524}, arg2: false);
                context.SetSkill(arg1: new int[] {525}, arg2: false);
                context.SetSkill(arg1: new int[] {526}, arg2: false);
                context.SetSkill(arg1: new int[] {527}, arg2: false);
                context.SetSkill(arg1: new int[] {528}, arg2: false);
                context.SetSkill(arg1: new int[] {529}, arg2: false);
                context.SetSkill(arg1: new int[] {530}, arg2: false);
                context.SetSkill(arg1: new int[] {531}, arg2: false);
                context.SetSkill(arg1: new int[] {532}, arg2: false);
                context.SetSkill(arg1: new int[] {533}, arg2: false);
                context.SetSkill(arg1: new int[] {534}, arg2: false);
                context.SetSkill(arg1: new int[] {535}, arg2: false);
                context.SetSkill(arg1: new int[] {536}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬05 : TriggerState {
            internal State스킬05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new int[] {566}, arg2: true);
                context.SetSkill(arg1: new int[] {567}, arg2: true);
                context.SetSkill(arg1: new int[] {568}, arg2: true);
                context.SetSkill(arg1: new int[] {565}, arg2: true);
                context.SetSkill(arg1: new int[] {564}, arg2: true);
                context.SetSkill(arg1: new int[] {527}, arg2: true);
                context.SetSkill(arg1: new int[] {528}, arg2: true);
                context.SetSkill(arg1: new int[] {529}, arg2: true);
                context.SetSkill(arg1: new int[] {530}, arg2: true);
                context.SetSkill(arg1: new int[] {531}, arg2: true);
                context.SetSkill(arg1: new int[] {532}, arg2: true);
                context.SetSkill(arg1: new int[] {533}, arg2: true);
                context.SetSkill(arg1: new int[] {534}, arg2: true);
                context.SetSkill(arg1: new int[] {535}, arg2: true);
                context.SetSkill(arg1: new int[] {536}, arg2: true);
                context.SetSkill(arg1: new int[] {537}, arg2: true);
                context.SetSkill(arg1: new int[] {538}, arg2: true);
                context.SetSkill(arg1: new int[] {539}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬04대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬04대기 : TriggerState {
            internal State스킬04대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {566}, arg2: false);
                context.SetSkill(arg1: new int[] {567}, arg2: false);
                context.SetSkill(arg1: new int[] {568}, arg2: false);
                context.SetSkill(arg1: new int[] {565}, arg2: false);
                context.SetSkill(arg1: new int[] {564}, arg2: false);
                context.SetSkill(arg1: new int[] {527}, arg2: false);
                context.SetSkill(arg1: new int[] {528}, arg2: false);
                context.SetSkill(arg1: new int[] {529}, arg2: false);
                context.SetSkill(arg1: new int[] {530}, arg2: false);
                context.SetSkill(arg1: new int[] {531}, arg2: false);
                context.SetSkill(arg1: new int[] {532}, arg2: false);
                context.SetSkill(arg1: new int[] {533}, arg2: false);
                context.SetSkill(arg1: new int[] {534}, arg2: false);
                context.SetSkill(arg1: new int[] {535}, arg2: false);
                context.SetSkill(arg1: new int[] {536}, arg2: false);
                context.SetSkill(arg1: new int[] {537}, arg2: false);
                context.SetSkill(arg1: new int[] {538}, arg2: false);
                context.SetSkill(arg1: new int[] {539}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬04 : TriggerState {
            internal State스킬04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new int[] {566}, arg2: false);
                context.SetSkill(arg1: new int[] {567}, arg2: false);
                context.SetSkill(arg1: new int[] {568}, arg2: false);
                context.SetSkill(arg1: new int[] {565}, arg2: true);
                context.SetSkill(arg1: new int[] {532}, arg2: true);
                context.SetSkill(arg1: new int[] {533}, arg2: true);
                context.SetSkill(arg1: new int[] {534}, arg2: true);
                context.SetSkill(arg1: new int[] {535}, arg2: true);
                context.SetSkill(arg1: new int[] {536}, arg2: true);
                context.SetSkill(arg1: new int[] {537}, arg2: true);
                context.SetSkill(arg1: new int[] {538}, arg2: true);
                context.SetSkill(arg1: new int[] {539}, arg2: true);
                context.SetSkill(arg1: new int[] {540}, arg2: true);
                context.SetSkill(arg1: new int[] {541}, arg2: true);
                context.SetSkill(arg1: new int[] {542}, arg2: true);
                context.SetSkill(arg1: new int[] {543}, arg2: true);
                context.SetSkill(arg1: new int[] {544}, arg2: true);
                context.SetSkill(arg1: new int[] {545}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬03대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬03대기 : TriggerState {
            internal State스킬03대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {566}, arg2: false);
                context.SetSkill(arg1: new int[] {567}, arg2: false);
                context.SetSkill(arg1: new int[] {568}, arg2: false);
                context.SetSkill(arg1: new int[] {565}, arg2: false);
                context.SetSkill(arg1: new int[] {532}, arg2: false);
                context.SetSkill(arg1: new int[] {533}, arg2: false);
                context.SetSkill(arg1: new int[] {534}, arg2: false);
                context.SetSkill(arg1: new int[] {535}, arg2: false);
                context.SetSkill(arg1: new int[] {536}, arg2: false);
                context.SetSkill(arg1: new int[] {537}, arg2: false);
                context.SetSkill(arg1: new int[] {538}, arg2: false);
                context.SetSkill(arg1: new int[] {539}, arg2: false);
                context.SetSkill(arg1: new int[] {540}, arg2: false);
                context.SetSkill(arg1: new int[] {541}, arg2: false);
                context.SetSkill(arg1: new int[] {542}, arg2: false);
                context.SetSkill(arg1: new int[] {543}, arg2: false);
                context.SetSkill(arg1: new int[] {544}, arg2: false);
                context.SetSkill(arg1: new int[] {545}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬03 : TriggerState {
            internal State스킬03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new int[] {566}, arg2: true);
                context.SetSkill(arg1: new int[] {567}, arg2: true);
                context.SetSkill(arg1: new int[] {568}, arg2: true);
                context.SetSkill(arg1: new int[] {537}, arg2: true);
                context.SetSkill(arg1: new int[] {538}, arg2: true);
                context.SetSkill(arg1: new int[] {539}, arg2: true);
                context.SetSkill(arg1: new int[] {540}, arg2: true);
                context.SetSkill(arg1: new int[] {541}, arg2: true);
                context.SetSkill(arg1: new int[] {542}, arg2: true);
                context.SetSkill(arg1: new int[] {543}, arg2: true);
                context.SetSkill(arg1: new int[] {544}, arg2: true);
                context.SetSkill(arg1: new int[] {545}, arg2: true);
                context.SetSkill(arg1: new int[] {546}, arg2: true);
                context.SetSkill(arg1: new int[] {547}, arg2: true);
                context.SetSkill(arg1: new int[] {548}, arg2: true);
                context.SetSkill(arg1: new int[] {549}, arg2: true);
                context.SetSkill(arg1: new int[] {550}, arg2: true);
                context.SetSkill(arg1: new int[] {551}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬02대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬02대기 : TriggerState {
            internal State스킬02대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {566}, arg2: false);
                context.SetSkill(arg1: new int[] {567}, arg2: false);
                context.SetSkill(arg1: new int[] {568}, arg2: false);
                context.SetSkill(arg1: new int[] {537}, arg2: false);
                context.SetSkill(arg1: new int[] {538}, arg2: false);
                context.SetSkill(arg1: new int[] {539}, arg2: false);
                context.SetSkill(arg1: new int[] {540}, arg2: false);
                context.SetSkill(arg1: new int[] {541}, arg2: false);
                context.SetSkill(arg1: new int[] {542}, arg2: false);
                context.SetSkill(arg1: new int[] {543}, arg2: false);
                context.SetSkill(arg1: new int[] {544}, arg2: false);
                context.SetSkill(arg1: new int[] {545}, arg2: false);
                context.SetSkill(arg1: new int[] {546}, arg2: false);
                context.SetSkill(arg1: new int[] {547}, arg2: false);
                context.SetSkill(arg1: new int[] {548}, arg2: false);
                context.SetSkill(arg1: new int[] {549}, arg2: false);
                context.SetSkill(arg1: new int[] {550}, arg2: false);
                context.SetSkill(arg1: new int[] {551}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬02 : TriggerState {
            internal State스킬02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new int[] {540}, arg2: true);
                context.SetSkill(arg1: new int[] {541}, arg2: true);
                context.SetSkill(arg1: new int[] {542}, arg2: true);
                context.SetSkill(arg1: new int[] {543}, arg2: true);
                context.SetSkill(arg1: new int[] {544}, arg2: true);
                context.SetSkill(arg1: new int[] {545}, arg2: true);
                context.SetSkill(arg1: new int[] {546}, arg2: true);
                context.SetSkill(arg1: new int[] {547}, arg2: true);
                context.SetSkill(arg1: new int[] {548}, arg2: true);
                context.SetSkill(arg1: new int[] {549}, arg2: true);
                context.SetSkill(arg1: new int[] {550}, arg2: true);
                context.SetSkill(arg1: new int[] {551}, arg2: true);
                context.SetSkill(arg1: new int[] {552}, arg2: true);
                context.SetSkill(arg1: new int[] {553}, arg2: true);
                context.SetSkill(arg1: new int[] {554}, arg2: true);
                context.SetSkill(arg1: new int[] {555}, arg2: true);
                context.SetSkill(arg1: new int[] {556}, arg2: true);
                context.SetSkill(arg1: new int[] {557}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬01대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬01대기 : TriggerState {
            internal State스킬01대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {540}, arg2: false);
                context.SetSkill(arg1: new int[] {541}, arg2: false);
                context.SetSkill(arg1: new int[] {542}, arg2: false);
                context.SetSkill(arg1: new int[] {543}, arg2: false);
                context.SetSkill(arg1: new int[] {544}, arg2: false);
                context.SetSkill(arg1: new int[] {545}, arg2: false);
                context.SetSkill(arg1: new int[] {546}, arg2: false);
                context.SetSkill(arg1: new int[] {547}, arg2: false);
                context.SetSkill(arg1: new int[] {548}, arg2: false);
                context.SetSkill(arg1: new int[] {549}, arg2: false);
                context.SetSkill(arg1: new int[] {550}, arg2: false);
                context.SetSkill(arg1: new int[] {551}, arg2: false);
                context.SetSkill(arg1: new int[] {552}, arg2: false);
                context.SetSkill(arg1: new int[] {553}, arg2: false);
                context.SetSkill(arg1: new int[] {554}, arg2: false);
                context.SetSkill(arg1: new int[] {555}, arg2: false);
                context.SetSkill(arg1: new int[] {556}, arg2: false);
                context.SetSkill(arg1: new int[] {557}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬01 : TriggerState {
            internal State스킬01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new int[] {546}, arg2: true);
                context.SetSkill(arg1: new int[] {547}, arg2: true);
                context.SetSkill(arg1: new int[] {548}, arg2: true);
                context.SetSkill(arg1: new int[] {549}, arg2: true);
                context.SetSkill(arg1: new int[] {550}, arg2: true);
                context.SetSkill(arg1: new int[] {551}, arg2: true);
                context.SetSkill(arg1: new int[] {552}, arg2: true);
                context.SetSkill(arg1: new int[] {553}, arg2: true);
                context.SetSkill(arg1: new int[] {554}, arg2: true);
                context.SetSkill(arg1: new int[] {555}, arg2: true);
                context.SetSkill(arg1: new int[] {556}, arg2: true);
                context.SetSkill(arg1: new int[] {557}, arg2: true);
                context.SetSkill(arg1: new int[] {558}, arg2: true);
                context.SetSkill(arg1: new int[] {559}, arg2: true);
                context.SetSkill(arg1: new int[] {560}, arg2: true);
                context.SetSkill(arg1: new int[] {561}, arg2: true);
                context.SetSkill(arg1: new int[] {562}, arg2: true);
                context.SetSkill(arg1: new int[] {563}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬00대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬00대기 : TriggerState {
            internal State스킬00대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {546}, arg2: false);
                context.SetSkill(arg1: new int[] {547}, arg2: false);
                context.SetSkill(arg1: new int[] {548}, arg2: false);
                context.SetSkill(arg1: new int[] {549}, arg2: false);
                context.SetSkill(arg1: new int[] {550}, arg2: false);
                context.SetSkill(arg1: new int[] {551}, arg2: false);
                context.SetSkill(arg1: new int[] {552}, arg2: false);
                context.SetSkill(arg1: new int[] {553}, arg2: false);
                context.SetSkill(arg1: new int[] {554}, arg2: false);
                context.SetSkill(arg1: new int[] {555}, arg2: false);
                context.SetSkill(arg1: new int[] {556}, arg2: false);
                context.SetSkill(arg1: new int[] {557}, arg2: false);
                context.SetSkill(arg1: new int[] {558}, arg2: false);
                context.SetSkill(arg1: new int[] {559}, arg2: false);
                context.SetSkill(arg1: new int[] {560}, arg2: false);
                context.SetSkill(arg1: new int[] {561}, arg2: false);
                context.SetSkill(arg1: new int[] {562}, arg2: false);
                context.SetSkill(arg1: new int[] {563}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬00(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬00 : TriggerState {
            internal State스킬00(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new int[] {552}, arg2: true);
                context.SetSkill(arg1: new int[] {553}, arg2: true);
                context.SetSkill(arg1: new int[] {554}, arg2: true);
                context.SetSkill(arg1: new int[] {555}, arg2: true);
                context.SetSkill(arg1: new int[] {556}, arg2: true);
                context.SetSkill(arg1: new int[] {557}, arg2: true);
                context.SetSkill(arg1: new int[] {558}, arg2: true);
                context.SetSkill(arg1: new int[] {559}, arg2: true);
                context.SetSkill(arg1: new int[] {560}, arg2: true);
                context.SetSkill(arg1: new int[] {561}, arg2: true);
                context.SetSkill(arg1: new int[] {562}, arg2: true);
                context.SetSkill(arg1: new int[] {563}, arg2: true);
                context.SetSkill(arg1: new int[] {301}, arg2: true);
                context.SetSkill(arg1: new int[] {302}, arg2: true);
                context.SetSkill(arg1: new int[] {303}, arg2: true);
                context.SetSkill(arg1: new int[] {304}, arg2: true);
                context.SetSkill(arg1: new int[] {305}, arg2: true);
                context.SetSkill(arg1: new int[] {306}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬0_5대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬0_5대기 : TriggerState {
            internal State스킬0_5대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {552}, arg2: false);
                context.SetSkill(arg1: new int[] {553}, arg2: false);
                context.SetSkill(arg1: new int[] {554}, arg2: false);
                context.SetSkill(arg1: new int[] {555}, arg2: false);
                context.SetSkill(arg1: new int[] {556}, arg2: false);
                context.SetSkill(arg1: new int[] {557}, arg2: false);
                context.SetSkill(arg1: new int[] {558}, arg2: false);
                context.SetSkill(arg1: new int[] {559}, arg2: false);
                context.SetSkill(arg1: new int[] {560}, arg2: false);
                context.SetSkill(arg1: new int[] {561}, arg2: false);
                context.SetSkill(arg1: new int[] {562}, arg2: false);
                context.SetSkill(arg1: new int[] {563}, arg2: false);
                context.SetSkill(arg1: new int[] {301}, arg2: false);
                context.SetSkill(arg1: new int[] {302}, arg2: false);
                context.SetSkill(arg1: new int[] {303}, arg2: false);
                context.SetSkill(arg1: new int[] {304}, arg2: false);
                context.SetSkill(arg1: new int[] {305}, arg2: false);
                context.SetSkill(arg1: new int[] {306}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬0_5(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬0_5 : TriggerState {
            internal State스킬0_5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new int[] {558}, arg2: true);
                context.SetSkill(arg1: new int[] {559}, arg2: true);
                context.SetSkill(arg1: new int[] {560}, arg2: true);
                context.SetSkill(arg1: new int[] {561}, arg2: true);
                context.SetSkill(arg1: new int[] {562}, arg2: true);
                context.SetSkill(arg1: new int[] {563}, arg2: true);
                context.SetSkill(arg1: new int[] {301}, arg2: true);
                context.SetSkill(arg1: new int[] {302}, arg2: true);
                context.SetSkill(arg1: new int[] {303}, arg2: true);
                context.SetSkill(arg1: new int[] {304}, arg2: true);
                context.SetSkill(arg1: new int[] {305}, arg2: true);
                context.SetSkill(arg1: new int[] {306}, arg2: true);
                context.SetSkill(arg1: new int[] {307}, arg2: true);
                context.SetSkill(arg1: new int[] {308}, arg2: true);
                context.SetSkill(arg1: new int[] {309}, arg2: true);
                context.SetSkill(arg1: new int[] {310}, arg2: true);
                context.SetSkill(arg1: new int[] {311}, arg2: true);
                context.SetSkill(arg1: new int[] {312}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬01대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬08대기 : TriggerState {
            internal State스킬08대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {341}, arg2: false);
                context.SetSkill(arg1: new int[] {342}, arg2: false);
                context.SetSkill(arg1: new int[] {343}, arg2: false);
                context.SetSkill(arg1: new int[] {344}, arg2: false);
                context.SetSkill(arg1: new int[] {345}, arg2: false);
                context.SetSkill(arg1: new int[] {346}, arg2: false);
                context.SetSkill(arg1: new int[] {347}, arg2: false);
                context.SetSkill(arg1: new int[] {348}, arg2: false);
                context.SetSkill(arg1: new int[] {349}, arg2: false);
                context.SetSkill(arg1: new int[] {350}, arg2: false);
                context.SetSkill(arg1: new int[] {351}, arg2: false);
                context.SetSkill(arg1: new int[] {352}, arg2: false);
                context.SetSkill(arg1: new int[] {353}, arg2: false);
                context.SetSkill(arg1: new int[] {354}, arg2: false);
                context.SetSkill(arg1: new int[] {355}, arg2: false);
                context.SetSkill(arg1: new int[] {356}, arg2: false);
                context.SetSkill(arg1: new int[] {357}, arg2: false);
                context.SetSkill(arg1: new int[] {358}, arg2: false);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000409}, arg2: 0)) {
                    context.State = new State굳음(context);
                    return;
                }

                if (true) {
                    context.State = new State스킬08(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State굳음 : TriggerState {
            internal State굳음(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "20", arg2: 20);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "20")) {
                    context.State = new State스킬08(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬09대기 : TriggerState {
            internal State스킬09대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {347}, arg2: false);
                context.SetSkill(arg1: new int[] {348}, arg2: false);
                context.SetSkill(arg1: new int[] {349}, arg2: false);
                context.SetSkill(arg1: new int[] {350}, arg2: false);
                context.SetSkill(arg1: new int[] {351}, arg2: false);
                context.SetSkill(arg1: new int[] {352}, arg2: false);
                context.SetSkill(arg1: new int[] {353}, arg2: false);
                context.SetSkill(arg1: new int[] {354}, arg2: false);
                context.SetSkill(arg1: new int[] {355}, arg2: false);
                context.SetSkill(arg1: new int[] {356}, arg2: false);
                context.SetSkill(arg1: new int[] {357}, arg2: false);
                context.SetSkill(arg1: new int[] {358}, arg2: false);
                context.SetSkill(arg1: new int[] {359}, arg2: false);
                context.SetSkill(arg1: new int[] {360}, arg2: false);
                context.SetSkill(arg1: new int[] {361}, arg2: false);
                context.SetSkill(arg1: new int[] {362}, arg2: false);
                context.SetSkill(arg1: new int[] {363}, arg2: false);
                context.SetSkill(arg1: new int[] {364}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬09(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬09 : TriggerState {
            internal State스킬09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new int[] {353}, arg2: true);
                context.SetSkill(arg1: new int[] {354}, arg2: true);
                context.SetSkill(arg1: new int[] {355}, arg2: true);
                context.SetSkill(arg1: new int[] {356}, arg2: true);
                context.SetSkill(arg1: new int[] {357}, arg2: true);
                context.SetSkill(arg1: new int[] {358}, arg2: true);
                context.SetSkill(arg1: new int[] {359}, arg2: true);
                context.SetSkill(arg1: new int[] {360}, arg2: true);
                context.SetSkill(arg1: new int[] {361}, arg2: true);
                context.SetSkill(arg1: new int[] {362}, arg2: true);
                context.SetSkill(arg1: new int[] {363}, arg2: true);
                context.SetSkill(arg1: new int[] {364}, arg2: true);
                context.SetSkill(arg1: new int[] {365}, arg2: true);
                context.SetSkill(arg1: new int[] {366}, arg2: true);
                context.SetSkill(arg1: new int[] {367}, arg2: true);
                context.SetSkill(arg1: new int[] {368}, arg2: true);
                context.SetSkill(arg1: new int[] {369}, arg2: true);
                context.SetSkill(arg1: new int[] {370}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬10대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬10대기 : TriggerState {
            internal State스킬10대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {353}, arg2: false);
                context.SetSkill(arg1: new int[] {354}, arg2: false);
                context.SetSkill(arg1: new int[] {355}, arg2: false);
                context.SetSkill(arg1: new int[] {356}, arg2: false);
                context.SetSkill(arg1: new int[] {357}, arg2: false);
                context.SetSkill(arg1: new int[] {358}, arg2: false);
                context.SetSkill(arg1: new int[] {359}, arg2: false);
                context.SetSkill(arg1: new int[] {360}, arg2: false);
                context.SetSkill(arg1: new int[] {361}, arg2: false);
                context.SetSkill(arg1: new int[] {362}, arg2: false);
                context.SetSkill(arg1: new int[] {363}, arg2: false);
                context.SetSkill(arg1: new int[] {364}, arg2: false);
                context.SetSkill(arg1: new int[] {365}, arg2: false);
                context.SetSkill(arg1: new int[] {366}, arg2: false);
                context.SetSkill(arg1: new int[] {367}, arg2: false);
                context.SetSkill(arg1: new int[] {368}, arg2: false);
                context.SetSkill(arg1: new int[] {369}, arg2: false);
                context.SetSkill(arg1: new int[] {370}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬10(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬10 : TriggerState {
            internal State스킬10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new int[] {359}, arg2: true);
                context.SetSkill(arg1: new int[] {360}, arg2: true);
                context.SetSkill(arg1: new int[] {361}, arg2: true);
                context.SetSkill(arg1: new int[] {362}, arg2: true);
                context.SetSkill(arg1: new int[] {363}, arg2: true);
                context.SetSkill(arg1: new int[] {364}, arg2: true);
                context.SetSkill(arg1: new int[] {365}, arg2: true);
                context.SetSkill(arg1: new int[] {366}, arg2: true);
                context.SetSkill(arg1: new int[] {367}, arg2: true);
                context.SetSkill(arg1: new int[] {368}, arg2: true);
                context.SetSkill(arg1: new int[] {369}, arg2: true);
                context.SetSkill(arg1: new int[] {370}, arg2: true);
                context.SetSkill(arg1: new int[] {371}, arg2: true);
                context.SetSkill(arg1: new int[] {372}, arg2: true);
                context.SetSkill(arg1: new int[] {373}, arg2: true);
                context.SetSkill(arg1: new int[] {374}, arg2: true);
                context.SetSkill(arg1: new int[] {375}, arg2: true);
                context.SetSkill(arg1: new int[] {376}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬11대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬11대기 : TriggerState {
            internal State스킬11대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 0);
                context.SetSkill(arg1: new int[] {359}, arg2: false);
                context.SetSkill(arg1: new int[] {360}, arg2: false);
                context.SetSkill(arg1: new int[] {361}, arg2: false);
                context.SetSkill(arg1: new int[] {362}, arg2: false);
                context.SetSkill(arg1: new int[] {363}, arg2: false);
                context.SetSkill(arg1: new int[] {364}, arg2: false);
                context.SetSkill(arg1: new int[] {365}, arg2: false);
                context.SetSkill(arg1: new int[] {366}, arg2: false);
                context.SetSkill(arg1: new int[] {367}, arg2: false);
                context.SetSkill(arg1: new int[] {368}, arg2: false);
                context.SetSkill(arg1: new int[] {369}, arg2: false);
                context.SetSkill(arg1: new int[] {370}, arg2: false);
                context.SetSkill(arg1: new int[] {371}, arg2: false);
                context.SetSkill(arg1: new int[] {372}, arg2: false);
                context.SetSkill(arg1: new int[] {373}, arg2: false);
                context.SetSkill(arg1: new int[] {374}, arg2: false);
                context.SetSkill(arg1: new int[] {375}, arg2: false);
                context.SetSkill(arg1: new int[] {376}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬12(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬12 : TriggerState {
            internal State스킬12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new int[] {365}, arg2: true);
                context.SetSkill(arg1: new int[] {366}, arg2: true);
                context.SetSkill(arg1: new int[] {367}, arg2: true);
                context.SetSkill(arg1: new int[] {368}, arg2: true);
                context.SetSkill(arg1: new int[] {369}, arg2: true);
                context.SetSkill(arg1: new int[] {370}, arg2: true);
                context.SetSkill(arg1: new int[] {371}, arg2: true);
                context.SetSkill(arg1: new int[] {372}, arg2: true);
                context.SetSkill(arg1: new int[] {373}, arg2: true);
                context.SetSkill(arg1: new int[] {374}, arg2: true);
                context.SetSkill(arg1: new int[] {375}, arg2: true);
                context.SetSkill(arg1: new int[] {376}, arg2: true);
                context.SetSkill(arg1: new int[] {377}, arg2: true);
                context.SetSkill(arg1: new int[] {378}, arg2: true);
                context.SetSkill(arg1: new int[] {379}, arg2: true);
                context.SetSkill(arg1: new int[] {380}, arg2: true);
                context.SetSkill(arg1: new int[] {381}, arg2: true);
                context.SetSkill(arg1: new int[] {382}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬13대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬13대기 : TriggerState {
            internal State스킬13대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {365}, arg2: false);
                context.SetSkill(arg1: new int[] {366}, arg2: false);
                context.SetSkill(arg1: new int[] {367}, arg2: false);
                context.SetSkill(arg1: new int[] {368}, arg2: false);
                context.SetSkill(arg1: new int[] {369}, arg2: false);
                context.SetSkill(arg1: new int[] {370}, arg2: false);
                context.SetSkill(arg1: new int[] {371}, arg2: false);
                context.SetSkill(arg1: new int[] {372}, arg2: false);
                context.SetSkill(arg1: new int[] {373}, arg2: false);
                context.SetSkill(arg1: new int[] {374}, arg2: false);
                context.SetSkill(arg1: new int[] {375}, arg2: false);
                context.SetSkill(arg1: new int[] {376}, arg2: false);
                context.SetSkill(arg1: new int[] {377}, arg2: false);
                context.SetSkill(arg1: new int[] {378}, arg2: false);
                context.SetSkill(arg1: new int[] {379}, arg2: false);
                context.SetSkill(arg1: new int[] {380}, arg2: false);
                context.SetSkill(arg1: new int[] {381}, arg2: false);
                context.SetSkill(arg1: new int[] {382}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬13(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬13 : TriggerState {
            internal State스킬13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new int[] {371}, arg2: true);
                context.SetSkill(arg1: new int[] {372}, arg2: true);
                context.SetSkill(arg1: new int[] {373}, arg2: true);
                context.SetSkill(arg1: new int[] {374}, arg2: true);
                context.SetSkill(arg1: new int[] {375}, arg2: true);
                context.SetSkill(arg1: new int[] {376}, arg2: true);
                context.SetSkill(arg1: new int[] {377}, arg2: true);
                context.SetSkill(arg1: new int[] {378}, arg2: true);
                context.SetSkill(arg1: new int[] {379}, arg2: true);
                context.SetSkill(arg1: new int[] {380}, arg2: true);
                context.SetSkill(arg1: new int[] {381}, arg2: true);
                context.SetSkill(arg1: new int[] {382}, arg2: true);
                context.SetSkill(arg1: new int[] {383}, arg2: true);
                context.SetSkill(arg1: new int[] {384}, arg2: true);
                context.SetSkill(arg1: new int[] {385}, arg2: true);
                context.SetSkill(arg1: new int[] {386}, arg2: true);
                context.SetSkill(arg1: new int[] {387}, arg2: true);
                context.SetSkill(arg1: new int[] {388}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬14대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬14대기 : TriggerState {
            internal State스킬14대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {371}, arg2: false);
                context.SetSkill(arg1: new int[] {372}, arg2: false);
                context.SetSkill(arg1: new int[] {373}, arg2: false);
                context.SetSkill(arg1: new int[] {374}, arg2: false);
                context.SetSkill(arg1: new int[] {375}, arg2: false);
                context.SetSkill(arg1: new int[] {376}, arg2: false);
                context.SetSkill(arg1: new int[] {377}, arg2: false);
                context.SetSkill(arg1: new int[] {378}, arg2: false);
                context.SetSkill(arg1: new int[] {379}, arg2: false);
                context.SetSkill(arg1: new int[] {380}, arg2: false);
                context.SetSkill(arg1: new int[] {381}, arg2: false);
                context.SetSkill(arg1: new int[] {382}, arg2: false);
                context.SetSkill(arg1: new int[] {383}, arg2: false);
                context.SetSkill(arg1: new int[] {384}, arg2: false);
                context.SetSkill(arg1: new int[] {385}, arg2: false);
                context.SetSkill(arg1: new int[] {386}, arg2: false);
                context.SetSkill(arg1: new int[] {387}, arg2: false);
                context.SetSkill(arg1: new int[] {388}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬14(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬14 : TriggerState {
            internal State스킬14(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new int[] {377}, arg2: true);
                context.SetSkill(arg1: new int[] {378}, arg2: true);
                context.SetSkill(arg1: new int[] {379}, arg2: true);
                context.SetSkill(arg1: new int[] {380}, arg2: true);
                context.SetSkill(arg1: new int[] {381}, arg2: true);
                context.SetSkill(arg1: new int[] {382}, arg2: true);
                context.SetSkill(arg1: new int[] {383}, arg2: true);
                context.SetSkill(arg1: new int[] {384}, arg2: true);
                context.SetSkill(arg1: new int[] {385}, arg2: true);
                context.SetSkill(arg1: new int[] {386}, arg2: true);
                context.SetSkill(arg1: new int[] {387}, arg2: true);
                context.SetSkill(arg1: new int[] {388}, arg2: true);
                context.SetSkill(arg1: new int[] {389}, arg2: true);
                context.SetSkill(arg1: new int[] {390}, arg2: true);
                context.SetSkill(arg1: new int[] {391}, arg2: true);
                context.SetSkill(arg1: new int[] {392}, arg2: true);
                context.SetSkill(arg1: new int[] {393}, arg2: true);
                context.SetSkill(arg1: new int[] {394}, arg2: true);
                context.SetSkill(arg1: new int[] {395}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬15대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬15대기 : TriggerState {
            internal State스킬15대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {377}, arg2: false);
                context.SetSkill(arg1: new int[] {378}, arg2: false);
                context.SetSkill(arg1: new int[] {379}, arg2: false);
                context.SetSkill(arg1: new int[] {380}, arg2: false);
                context.SetSkill(arg1: new int[] {381}, arg2: false);
                context.SetSkill(arg1: new int[] {382}, arg2: false);
                context.SetSkill(arg1: new int[] {383}, arg2: false);
                context.SetSkill(arg1: new int[] {384}, arg2: false);
                context.SetSkill(arg1: new int[] {385}, arg2: false);
                context.SetSkill(arg1: new int[] {386}, arg2: false);
                context.SetSkill(arg1: new int[] {387}, arg2: false);
                context.SetSkill(arg1: new int[] {388}, arg2: false);
                context.SetSkill(arg1: new int[] {389}, arg2: false);
                context.SetSkill(arg1: new int[] {390}, arg2: false);
                context.SetSkill(arg1: new int[] {391}, arg2: false);
                context.SetSkill(arg1: new int[] {392}, arg2: false);
                context.SetSkill(arg1: new int[] {393}, arg2: false);
                context.SetSkill(arg1: new int[] {394}, arg2: false);
                context.SetSkill(arg1: new int[] {395}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬15(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬15 : TriggerState {
            internal State스킬15(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new int[] {383}, arg2: true);
                context.SetSkill(arg1: new int[] {384}, arg2: true);
                context.SetSkill(arg1: new int[] {385}, arg2: true);
                context.SetSkill(arg1: new int[] {386}, arg2: true);
                context.SetSkill(arg1: new int[] {387}, arg2: true);
                context.SetSkill(arg1: new int[] {388}, arg2: true);
                context.SetSkill(arg1: new int[] {389}, arg2: true);
                context.SetSkill(arg1: new int[] {390}, arg2: true);
                context.SetSkill(arg1: new int[] {391}, arg2: true);
                context.SetSkill(arg1: new int[] {392}, arg2: true);
                context.SetSkill(arg1: new int[] {393}, arg2: true);
                context.SetSkill(arg1: new int[] {394}, arg2: true);
                context.SetSkill(arg1: new int[] {395}, arg2: true);
                context.SetSkill(arg1: new int[] {396}, arg2: true);
                context.SetSkill(arg1: new int[] {397}, arg2: true);
                context.SetSkill(arg1: new int[] {398}, arg2: true);
                context.SetSkill(arg1: new int[] {399}, arg2: true);
                context.SetSkill(arg1: new int[] {400}, arg2: true);
                context.SetSkill(arg1: new int[] {401}, arg2: true);
                context.SetSkill(arg1: new int[] {402}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬16대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬16대기 : TriggerState {
            internal State스킬16대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {383}, arg2: false);
                context.SetSkill(arg1: new int[] {384}, arg2: false);
                context.SetSkill(arg1: new int[] {385}, arg2: false);
                context.SetSkill(arg1: new int[] {386}, arg2: false);
                context.SetSkill(arg1: new int[] {387}, arg2: false);
                context.SetSkill(arg1: new int[] {388}, arg2: false);
                context.SetSkill(arg1: new int[] {389}, arg2: false);
                context.SetSkill(arg1: new int[] {390}, arg2: false);
                context.SetSkill(arg1: new int[] {391}, arg2: false);
                context.SetSkill(arg1: new int[] {392}, arg2: false);
                context.SetSkill(arg1: new int[] {393}, arg2: false);
                context.SetSkill(arg1: new int[] {394}, arg2: false);
                context.SetSkill(arg1: new int[] {395}, arg2: false);
                context.SetSkill(arg1: new int[] {396}, arg2: false);
                context.SetSkill(arg1: new int[] {397}, arg2: false);
                context.SetSkill(arg1: new int[] {398}, arg2: false);
                context.SetSkill(arg1: new int[] {399}, arg2: false);
                context.SetSkill(arg1: new int[] {400}, arg2: false);
                context.SetSkill(arg1: new int[] {401}, arg2: false);
                context.SetSkill(arg1: new int[] {402}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬16(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬16 : TriggerState {
            internal State스킬16(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new int[] {389}, arg2: true);
                context.SetSkill(arg1: new int[] {390}, arg2: true);
                context.SetSkill(arg1: new int[] {391}, arg2: true);
                context.SetSkill(arg1: new int[] {392}, arg2: true);
                context.SetSkill(arg1: new int[] {393}, arg2: true);
                context.SetSkill(arg1: new int[] {394}, arg2: true);
                context.SetSkill(arg1: new int[] {395}, arg2: true);
                context.SetSkill(arg1: new int[] {396}, arg2: true);
                context.SetSkill(arg1: new int[] {397}, arg2: true);
                context.SetSkill(arg1: new int[] {398}, arg2: true);
                context.SetSkill(arg1: new int[] {399}, arg2: true);
                context.SetSkill(arg1: new int[] {400}, arg2: true);
                context.SetSkill(arg1: new int[] {401}, arg2: true);
                context.SetSkill(arg1: new int[] {402}, arg2: true);
                context.SetSkill(arg1: new int[] {403}, arg2: true);
                context.SetSkill(arg1: new int[] {404}, arg2: true);
                context.SetSkill(arg1: new int[] {405}, arg2: true);
                context.SetSkill(arg1: new int[] {406}, arg2: true);
                context.SetSkill(arg1: new int[] {407}, arg2: true);
                context.SetSkill(arg1: new int[] {408}, arg2: true);
                context.SetSkill(arg1: new int[] {409}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬17대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬17대기 : TriggerState {
            internal State스킬17대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {389}, arg2: false);
                context.SetSkill(arg1: new int[] {390}, arg2: false);
                context.SetSkill(arg1: new int[] {391}, arg2: false);
                context.SetSkill(arg1: new int[] {392}, arg2: false);
                context.SetSkill(arg1: new int[] {393}, arg2: false);
                context.SetSkill(arg1: new int[] {394}, arg2: false);
                context.SetSkill(arg1: new int[] {395}, arg2: false);
                context.SetSkill(arg1: new int[] {396}, arg2: false);
                context.SetSkill(arg1: new int[] {397}, arg2: false);
                context.SetSkill(arg1: new int[] {398}, arg2: false);
                context.SetSkill(arg1: new int[] {399}, arg2: false);
                context.SetSkill(arg1: new int[] {400}, arg2: false);
                context.SetSkill(arg1: new int[] {401}, arg2: false);
                context.SetSkill(arg1: new int[] {402}, arg2: false);
                context.SetSkill(arg1: new int[] {403}, arg2: false);
                context.SetSkill(arg1: new int[] {404}, arg2: false);
                context.SetSkill(arg1: new int[] {405}, arg2: false);
                context.SetSkill(arg1: new int[] {406}, arg2: false);
                context.SetSkill(arg1: new int[] {407}, arg2: false);
                context.SetSkill(arg1: new int[] {408}, arg2: false);
                context.SetSkill(arg1: new int[] {409}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬17(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬17 : TriggerState {
            internal State스킬17(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new int[] {396}, arg2: true);
                context.SetSkill(arg1: new int[] {397}, arg2: true);
                context.SetSkill(arg1: new int[] {398}, arg2: true);
                context.SetSkill(arg1: new int[] {399}, arg2: true);
                context.SetSkill(arg1: new int[] {400}, arg2: true);
                context.SetSkill(arg1: new int[] {401}, arg2: true);
                context.SetSkill(arg1: new int[] {402}, arg2: true);
                context.SetSkill(arg1: new int[] {403}, arg2: true);
                context.SetSkill(arg1: new int[] {404}, arg2: true);
                context.SetSkill(arg1: new int[] {405}, arg2: true);
                context.SetSkill(arg1: new int[] {406}, arg2: true);
                context.SetSkill(arg1: new int[] {407}, arg2: true);
                context.SetSkill(arg1: new int[] {408}, arg2: true);
                context.SetSkill(arg1: new int[] {409}, arg2: true);
                context.SetSkill(arg1: new int[] {410}, arg2: true);
                context.SetSkill(arg1: new int[] {411}, arg2: true);
                context.SetSkill(arg1: new int[] {412}, arg2: true);
                context.SetSkill(arg1: new int[] {413}, arg2: true);
                context.SetSkill(arg1: new int[] {414}, arg2: true);
                context.SetSkill(arg1: new int[] {415}, arg2: true);
                context.SetSkill(arg1: new int[] {416}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬18대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬18대기 : TriggerState {
            internal State스킬18대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {396}, arg2: false);
                context.SetSkill(arg1: new int[] {397}, arg2: false);
                context.SetSkill(arg1: new int[] {398}, arg2: false);
                context.SetSkill(arg1: new int[] {399}, arg2: false);
                context.SetSkill(arg1: new int[] {400}, arg2: false);
                context.SetSkill(arg1: new int[] {401}, arg2: false);
                context.SetSkill(arg1: new int[] {402}, arg2: false);
                context.SetSkill(arg1: new int[] {403}, arg2: false);
                context.SetSkill(arg1: new int[] {404}, arg2: false);
                context.SetSkill(arg1: new int[] {405}, arg2: false);
                context.SetSkill(arg1: new int[] {406}, arg2: false);
                context.SetSkill(arg1: new int[] {407}, arg2: false);
                context.SetSkill(arg1: new int[] {408}, arg2: false);
                context.SetSkill(arg1: new int[] {409}, arg2: false);
                context.SetSkill(arg1: new int[] {410}, arg2: false);
                context.SetSkill(arg1: new int[] {411}, arg2: false);
                context.SetSkill(arg1: new int[] {412}, arg2: false);
                context.SetSkill(arg1: new int[] {413}, arg2: false);
                context.SetSkill(arg1: new int[] {414}, arg2: false);
                context.SetSkill(arg1: new int[] {415}, arg2: false);
                context.SetSkill(arg1: new int[] {416}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬18(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬18 : TriggerState {
            internal State스킬18(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new int[] {403}, arg2: true);
                context.SetSkill(arg1: new int[] {404}, arg2: true);
                context.SetSkill(arg1: new int[] {405}, arg2: true);
                context.SetSkill(arg1: new int[] {406}, arg2: true);
                context.SetSkill(arg1: new int[] {407}, arg2: true);
                context.SetSkill(arg1: new int[] {408}, arg2: true);
                context.SetSkill(arg1: new int[] {409}, arg2: true);
                context.SetSkill(arg1: new int[] {410}, arg2: true);
                context.SetSkill(arg1: new int[] {411}, arg2: true);
                context.SetSkill(arg1: new int[] {412}, arg2: true);
                context.SetSkill(arg1: new int[] {413}, arg2: true);
                context.SetSkill(arg1: new int[] {414}, arg2: true);
                context.SetSkill(arg1: new int[] {415}, arg2: true);
                context.SetSkill(arg1: new int[] {416}, arg2: true);
                context.SetSkill(arg1: new int[] {417}, arg2: true);
                context.SetSkill(arg1: new int[] {418}, arg2: true);
                context.SetSkill(arg1: new int[] {419}, arg2: true);
                context.SetSkill(arg1: new int[] {420}, arg2: true);
                context.SetSkill(arg1: new int[] {421}, arg2: true);
                context.SetSkill(arg1: new int[] {422}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬19대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬19대기 : TriggerState {
            internal State스킬19대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {403}, arg2: false);
                context.SetSkill(arg1: new int[] {404}, arg2: false);
                context.SetSkill(arg1: new int[] {405}, arg2: false);
                context.SetSkill(arg1: new int[] {406}, arg2: false);
                context.SetSkill(arg1: new int[] {407}, arg2: false);
                context.SetSkill(arg1: new int[] {408}, arg2: false);
                context.SetSkill(arg1: new int[] {409}, arg2: false);
                context.SetSkill(arg1: new int[] {410}, arg2: false);
                context.SetSkill(arg1: new int[] {411}, arg2: false);
                context.SetSkill(arg1: new int[] {412}, arg2: false);
                context.SetSkill(arg1: new int[] {413}, arg2: false);
                context.SetSkill(arg1: new int[] {414}, arg2: false);
                context.SetSkill(arg1: new int[] {415}, arg2: false);
                context.SetSkill(arg1: new int[] {416}, arg2: false);
                context.SetSkill(arg1: new int[] {417}, arg2: false);
                context.SetSkill(arg1: new int[] {418}, arg2: false);
                context.SetSkill(arg1: new int[] {419}, arg2: false);
                context.SetSkill(arg1: new int[] {420}, arg2: false);
                context.SetSkill(arg1: new int[] {421}, arg2: false);
                context.SetSkill(arg1: new int[] {422}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬19(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬19 : TriggerState {
            internal State스킬19(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new int[] {410}, arg2: true);
                context.SetSkill(arg1: new int[] {411}, arg2: true);
                context.SetSkill(arg1: new int[] {412}, arg2: true);
                context.SetSkill(arg1: new int[] {413}, arg2: true);
                context.SetSkill(arg1: new int[] {414}, arg2: true);
                context.SetSkill(arg1: new int[] {415}, arg2: true);
                context.SetSkill(arg1: new int[] {416}, arg2: true);
                context.SetSkill(arg1: new int[] {417}, arg2: true);
                context.SetSkill(arg1: new int[] {418}, arg2: true);
                context.SetSkill(arg1: new int[] {419}, arg2: true);
                context.SetSkill(arg1: new int[] {420}, arg2: true);
                context.SetSkill(arg1: new int[] {421}, arg2: true);
                context.SetSkill(arg1: new int[] {422}, arg2: true);
                context.SetSkill(arg1: new int[] {423}, arg2: true);
                context.SetSkill(arg1: new int[] {424}, arg2: true);
                context.SetSkill(arg1: new int[] {425}, arg2: true);
                context.SetSkill(arg1: new int[] {426}, arg2: true);
                context.SetSkill(arg1: new int[] {427}, arg2: true);
                context.SetSkill(arg1: new int[] {428}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬20대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬20대기 : TriggerState {
            internal State스킬20대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {410}, arg2: false);
                context.SetSkill(arg1: new int[] {411}, arg2: false);
                context.SetSkill(arg1: new int[] {412}, arg2: false);
                context.SetSkill(arg1: new int[] {413}, arg2: false);
                context.SetSkill(arg1: new int[] {414}, arg2: false);
                context.SetSkill(arg1: new int[] {415}, arg2: false);
                context.SetSkill(arg1: new int[] {416}, arg2: false);
                context.SetSkill(arg1: new int[] {417}, arg2: false);
                context.SetSkill(arg1: new int[] {418}, arg2: false);
                context.SetSkill(arg1: new int[] {419}, arg2: false);
                context.SetSkill(arg1: new int[] {420}, arg2: false);
                context.SetSkill(arg1: new int[] {421}, arg2: false);
                context.SetSkill(arg1: new int[] {422}, arg2: false);
                context.SetSkill(arg1: new int[] {423}, arg2: false);
                context.SetSkill(arg1: new int[] {424}, arg2: false);
                context.SetSkill(arg1: new int[] {425}, arg2: false);
                context.SetSkill(arg1: new int[] {426}, arg2: false);
                context.SetSkill(arg1: new int[] {427}, arg2: false);
                context.SetSkill(arg1: new int[] {428}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬20(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬20 : TriggerState {
            internal State스킬20(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new int[] {417}, arg2: true);
                context.SetSkill(arg1: new int[] {418}, arg2: true);
                context.SetSkill(arg1: new int[] {419}, arg2: true);
                context.SetSkill(arg1: new int[] {420}, arg2: true);
                context.SetSkill(arg1: new int[] {421}, arg2: true);
                context.SetSkill(arg1: new int[] {422}, arg2: true);
                context.SetSkill(arg1: new int[] {423}, arg2: true);
                context.SetSkill(arg1: new int[] {424}, arg2: true);
                context.SetSkill(arg1: new int[] {425}, arg2: true);
                context.SetSkill(arg1: new int[] {426}, arg2: true);
                context.SetSkill(arg1: new int[] {427}, arg2: true);
                context.SetSkill(arg1: new int[] {428}, arg2: true);
                context.SetSkill(arg1: new int[] {429}, arg2: true);
                context.SetSkill(arg1: new int[] {430}, arg2: true);
                context.SetSkill(arg1: new int[] {431}, arg2: true);
                context.SetSkill(arg1: new int[] {432}, arg2: true);
                context.SetSkill(arg1: new int[] {433}, arg2: true);
                context.SetSkill(arg1: new int[] {434}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬21대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬21대기 : TriggerState {
            internal State스킬21대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {417}, arg2: false);
                context.SetSkill(arg1: new int[] {418}, arg2: false);
                context.SetSkill(arg1: new int[] {419}, arg2: false);
                context.SetSkill(arg1: new int[] {420}, arg2: false);
                context.SetSkill(arg1: new int[] {421}, arg2: false);
                context.SetSkill(arg1: new int[] {422}, arg2: false);
                context.SetSkill(arg1: new int[] {423}, arg2: false);
                context.SetSkill(arg1: new int[] {424}, arg2: false);
                context.SetSkill(arg1: new int[] {425}, arg2: false);
                context.SetSkill(arg1: new int[] {426}, arg2: false);
                context.SetSkill(arg1: new int[] {427}, arg2: false);
                context.SetSkill(arg1: new int[] {428}, arg2: false);
                context.SetSkill(arg1: new int[] {429}, arg2: false);
                context.SetSkill(arg1: new int[] {430}, arg2: false);
                context.SetSkill(arg1: new int[] {431}, arg2: false);
                context.SetSkill(arg1: new int[] {432}, arg2: false);
                context.SetSkill(arg1: new int[] {433}, arg2: false);
                context.SetSkill(arg1: new int[] {434}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬21(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬21 : TriggerState {
            internal State스킬21(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new int[] {423}, arg2: true);
                context.SetSkill(arg1: new int[] {424}, arg2: true);
                context.SetSkill(arg1: new int[] {425}, arg2: true);
                context.SetSkill(arg1: new int[] {426}, arg2: true);
                context.SetSkill(arg1: new int[] {427}, arg2: true);
                context.SetSkill(arg1: new int[] {428}, arg2: true);
                context.SetSkill(arg1: new int[] {429}, arg2: true);
                context.SetSkill(arg1: new int[] {430}, arg2: true);
                context.SetSkill(arg1: new int[] {431}, arg2: true);
                context.SetSkill(arg1: new int[] {432}, arg2: true);
                context.SetSkill(arg1: new int[] {433}, arg2: true);
                context.SetSkill(arg1: new int[] {434}, arg2: true);
                context.SetSkill(arg1: new int[] {435}, arg2: true);
                context.SetSkill(arg1: new int[] {436}, arg2: true);
                context.SetSkill(arg1: new int[] {437}, arg2: true);
                context.SetSkill(arg1: new int[] {438}, arg2: true);
                context.SetSkill(arg1: new int[] {439}, arg2: true);
                context.SetSkill(arg1: new int[] {440}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬22대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬22대기 : TriggerState {
            internal State스킬22대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {423}, arg2: false);
                context.SetSkill(arg1: new int[] {424}, arg2: false);
                context.SetSkill(arg1: new int[] {425}, arg2: false);
                context.SetSkill(arg1: new int[] {426}, arg2: false);
                context.SetSkill(arg1: new int[] {427}, arg2: false);
                context.SetSkill(arg1: new int[] {428}, arg2: false);
                context.SetSkill(arg1: new int[] {429}, arg2: false);
                context.SetSkill(arg1: new int[] {430}, arg2: false);
                context.SetSkill(arg1: new int[] {431}, arg2: false);
                context.SetSkill(arg1: new int[] {432}, arg2: false);
                context.SetSkill(arg1: new int[] {433}, arg2: false);
                context.SetSkill(arg1: new int[] {434}, arg2: false);
                context.SetSkill(arg1: new int[] {435}, arg2: false);
                context.SetSkill(arg1: new int[] {436}, arg2: false);
                context.SetSkill(arg1: new int[] {437}, arg2: false);
                context.SetSkill(arg1: new int[] {438}, arg2: false);
                context.SetSkill(arg1: new int[] {439}, arg2: false);
                context.SetSkill(arg1: new int[] {440}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬22(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬22 : TriggerState {
            internal State스킬22(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new int[] {429}, arg2: true);
                context.SetSkill(arg1: new int[] {430}, arg2: true);
                context.SetSkill(arg1: new int[] {431}, arg2: true);
                context.SetSkill(arg1: new int[] {432}, arg2: true);
                context.SetSkill(arg1: new int[] {433}, arg2: true);
                context.SetSkill(arg1: new int[] {434}, arg2: true);
                context.SetSkill(arg1: new int[] {435}, arg2: true);
                context.SetSkill(arg1: new int[] {436}, arg2: true);
                context.SetSkill(arg1: new int[] {437}, arg2: true);
                context.SetSkill(arg1: new int[] {438}, arg2: true);
                context.SetSkill(arg1: new int[] {439}, arg2: true);
                context.SetSkill(arg1: new int[] {440}, arg2: true);
                context.SetSkill(arg1: new int[] {441}, arg2: true);
                context.SetSkill(arg1: new int[] {442}, arg2: true);
                context.SetSkill(arg1: new int[] {443}, arg2: true);
                context.SetSkill(arg1: new int[] {444}, arg2: true);
                context.SetSkill(arg1: new int[] {445}, arg2: true);
                context.SetSkill(arg1: new int[] {446}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬23대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬23대기 : TriggerState {
            internal State스킬23대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {429}, arg2: false);
                context.SetSkill(arg1: new int[] {430}, arg2: false);
                context.SetSkill(arg1: new int[] {431}, arg2: false);
                context.SetSkill(arg1: new int[] {432}, arg2: false);
                context.SetSkill(arg1: new int[] {433}, arg2: false);
                context.SetSkill(arg1: new int[] {434}, arg2: false);
                context.SetSkill(arg1: new int[] {435}, arg2: false);
                context.SetSkill(arg1: new int[] {436}, arg2: false);
                context.SetSkill(arg1: new int[] {437}, arg2: false);
                context.SetSkill(arg1: new int[] {438}, arg2: false);
                context.SetSkill(arg1: new int[] {439}, arg2: false);
                context.SetSkill(arg1: new int[] {440}, arg2: false);
                context.SetSkill(arg1: new int[] {441}, arg2: false);
                context.SetSkill(arg1: new int[] {442}, arg2: false);
                context.SetSkill(arg1: new int[] {443}, arg2: false);
                context.SetSkill(arg1: new int[] {444}, arg2: false);
                context.SetSkill(arg1: new int[] {445}, arg2: false);
                context.SetSkill(arg1: new int[] {446}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬23(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬23 : TriggerState {
            internal State스킬23(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new int[] {435}, arg2: true);
                context.SetSkill(arg1: new int[] {436}, arg2: true);
                context.SetSkill(arg1: new int[] {437}, arg2: true);
                context.SetSkill(arg1: new int[] {438}, arg2: true);
                context.SetSkill(arg1: new int[] {439}, arg2: true);
                context.SetSkill(arg1: new int[] {440}, arg2: true);
                context.SetSkill(arg1: new int[] {441}, arg2: true);
                context.SetSkill(arg1: new int[] {442}, arg2: true);
                context.SetSkill(arg1: new int[] {443}, arg2: true);
                context.SetSkill(arg1: new int[] {444}, arg2: true);
                context.SetSkill(arg1: new int[] {445}, arg2: true);
                context.SetSkill(arg1: new int[] {446}, arg2: true);
                context.SetSkill(arg1: new int[] {447}, arg2: true);
                context.SetSkill(arg1: new int[] {448}, arg2: true);
                context.SetSkill(arg1: new int[] {449}, arg2: true);
                context.SetSkill(arg1: new int[] {450}, arg2: true);
                context.SetSkill(arg1: new int[] {451}, arg2: true);
                context.SetSkill(arg1: new int[] {452}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬24대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬24대기 : TriggerState {
            internal State스킬24대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {435}, arg2: false);
                context.SetSkill(arg1: new int[] {436}, arg2: false);
                context.SetSkill(arg1: new int[] {437}, arg2: false);
                context.SetSkill(arg1: new int[] {438}, arg2: false);
                context.SetSkill(arg1: new int[] {439}, arg2: false);
                context.SetSkill(arg1: new int[] {440}, arg2: false);
                context.SetSkill(arg1: new int[] {441}, arg2: false);
                context.SetSkill(arg1: new int[] {442}, arg2: false);
                context.SetSkill(arg1: new int[] {443}, arg2: false);
                context.SetSkill(arg1: new int[] {444}, arg2: false);
                context.SetSkill(arg1: new int[] {445}, arg2: false);
                context.SetSkill(arg1: new int[] {446}, arg2: false);
                context.SetSkill(arg1: new int[] {447}, arg2: false);
                context.SetSkill(arg1: new int[] {448}, arg2: false);
                context.SetSkill(arg1: new int[] {449}, arg2: false);
                context.SetSkill(arg1: new int[] {450}, arg2: false);
                context.SetSkill(arg1: new int[] {451}, arg2: false);
                context.SetSkill(arg1: new int[] {452}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬24(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬24 : TriggerState {
            internal State스킬24(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new int[] {441}, arg2: true);
                context.SetSkill(arg1: new int[] {442}, arg2: true);
                context.SetSkill(arg1: new int[] {443}, arg2: true);
                context.SetSkill(arg1: new int[] {444}, arg2: true);
                context.SetSkill(arg1: new int[] {445}, arg2: true);
                context.SetSkill(arg1: new int[] {446}, arg2: true);
                context.SetSkill(arg1: new int[] {447}, arg2: true);
                context.SetSkill(arg1: new int[] {448}, arg2: true);
                context.SetSkill(arg1: new int[] {449}, arg2: true);
                context.SetSkill(arg1: new int[] {450}, arg2: true);
                context.SetSkill(arg1: new int[] {451}, arg2: true);
                context.SetSkill(arg1: new int[] {452}, arg2: true);
                context.SetSkill(arg1: new int[] {453}, arg2: true);
                context.SetSkill(arg1: new int[] {454}, arg2: true);
                context.SetSkill(arg1: new int[] {455}, arg2: true);
                context.SetSkill(arg1: new int[] {456}, arg2: true);
                context.SetSkill(arg1: new int[] {457}, arg2: true);
                context.SetSkill(arg1: new int[] {458}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬25대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬25대기 : TriggerState {
            internal State스킬25대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {441}, arg2: false);
                context.SetSkill(arg1: new int[] {442}, arg2: false);
                context.SetSkill(arg1: new int[] {443}, arg2: false);
                context.SetSkill(arg1: new int[] {444}, arg2: false);
                context.SetSkill(arg1: new int[] {445}, arg2: false);
                context.SetSkill(arg1: new int[] {446}, arg2: false);
                context.SetSkill(arg1: new int[] {447}, arg2: false);
                context.SetSkill(arg1: new int[] {448}, arg2: false);
                context.SetSkill(arg1: new int[] {449}, arg2: false);
                context.SetSkill(arg1: new int[] {450}, arg2: false);
                context.SetSkill(arg1: new int[] {451}, arg2: false);
                context.SetSkill(arg1: new int[] {452}, arg2: false);
                context.SetSkill(arg1: new int[] {453}, arg2: false);
                context.SetSkill(arg1: new int[] {454}, arg2: false);
                context.SetSkill(arg1: new int[] {455}, arg2: false);
                context.SetSkill(arg1: new int[] {456}, arg2: false);
                context.SetSkill(arg1: new int[] {457}, arg2: false);
                context.SetSkill(arg1: new int[] {458}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬25(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬25 : TriggerState {
            internal State스킬25(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new int[] {447}, arg2: true);
                context.SetSkill(arg1: new int[] {448}, arg2: true);
                context.SetSkill(arg1: new int[] {449}, arg2: true);
                context.SetSkill(arg1: new int[] {450}, arg2: true);
                context.SetSkill(arg1: new int[] {451}, arg2: true);
                context.SetSkill(arg1: new int[] {452}, arg2: true);
                context.SetSkill(arg1: new int[] {453}, arg2: true);
                context.SetSkill(arg1: new int[] {454}, arg2: true);
                context.SetSkill(arg1: new int[] {455}, arg2: true);
                context.SetSkill(arg1: new int[] {456}, arg2: true);
                context.SetSkill(arg1: new int[] {457}, arg2: true);
                context.SetSkill(arg1: new int[] {458}, arg2: true);
                context.SetSkill(arg1: new int[] {459}, arg2: true);
                context.SetSkill(arg1: new int[] {460}, arg2: true);
                context.SetSkill(arg1: new int[] {461}, arg2: true);
                context.SetSkill(arg1: new int[] {462}, arg2: true);
                context.SetSkill(arg1: new int[] {463}, arg2: true);
                context.SetSkill(arg1: new int[] {464}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬26대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬26대기 : TriggerState {
            internal State스킬26대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {447}, arg2: false);
                context.SetSkill(arg1: new int[] {448}, arg2: false);
                context.SetSkill(arg1: new int[] {449}, arg2: false);
                context.SetSkill(arg1: new int[] {450}, arg2: false);
                context.SetSkill(arg1: new int[] {451}, arg2: false);
                context.SetSkill(arg1: new int[] {452}, arg2: false);
                context.SetSkill(arg1: new int[] {453}, arg2: false);
                context.SetSkill(arg1: new int[] {454}, arg2: false);
                context.SetSkill(arg1: new int[] {455}, arg2: false);
                context.SetSkill(arg1: new int[] {456}, arg2: false);
                context.SetSkill(arg1: new int[] {457}, arg2: false);
                context.SetSkill(arg1: new int[] {458}, arg2: false);
                context.SetSkill(arg1: new int[] {459}, arg2: false);
                context.SetSkill(arg1: new int[] {460}, arg2: false);
                context.SetSkill(arg1: new int[] {461}, arg2: false);
                context.SetSkill(arg1: new int[] {462}, arg2: false);
                context.SetSkill(arg1: new int[] {463}, arg2: false);
                context.SetSkill(arg1: new int[] {464}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬26(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬26 : TriggerState {
            internal State스킬26(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new int[] {453}, arg2: true);
                context.SetSkill(arg1: new int[] {454}, arg2: true);
                context.SetSkill(arg1: new int[] {455}, arg2: true);
                context.SetSkill(arg1: new int[] {456}, arg2: true);
                context.SetSkill(arg1: new int[] {457}, arg2: true);
                context.SetSkill(arg1: new int[] {458}, arg2: true);
                context.SetSkill(arg1: new int[] {459}, arg2: true);
                context.SetSkill(arg1: new int[] {460}, arg2: true);
                context.SetSkill(arg1: new int[] {461}, arg2: true);
                context.SetSkill(arg1: new int[] {462}, arg2: true);
                context.SetSkill(arg1: new int[] {463}, arg2: true);
                context.SetSkill(arg1: new int[] {464}, arg2: true);
                context.SetSkill(arg1: new int[] {465}, arg2: true);
                context.SetSkill(arg1: new int[] {466}, arg2: true);
                context.SetSkill(arg1: new int[] {467}, arg2: true);
                context.SetSkill(arg1: new int[] {468}, arg2: true);
                context.SetSkill(arg1: new int[] {469}, arg2: true);
                context.SetSkill(arg1: new int[] {470}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬27대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬27대기 : TriggerState {
            internal State스킬27대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {453}, arg2: false);
                context.SetSkill(arg1: new int[] {454}, arg2: false);
                context.SetSkill(arg1: new int[] {455}, arg2: false);
                context.SetSkill(arg1: new int[] {456}, arg2: false);
                context.SetSkill(arg1: new int[] {457}, arg2: false);
                context.SetSkill(arg1: new int[] {458}, arg2: false);
                context.SetSkill(arg1: new int[] {459}, arg2: false);
                context.SetSkill(arg1: new int[] {460}, arg2: false);
                context.SetSkill(arg1: new int[] {461}, arg2: false);
                context.SetSkill(arg1: new int[] {462}, arg2: false);
                context.SetSkill(arg1: new int[] {463}, arg2: false);
                context.SetSkill(arg1: new int[] {464}, arg2: false);
                context.SetSkill(arg1: new int[] {465}, arg2: false);
                context.SetSkill(arg1: new int[] {466}, arg2: false);
                context.SetSkill(arg1: new int[] {467}, arg2: false);
                context.SetSkill(arg1: new int[] {468}, arg2: false);
                context.SetSkill(arg1: new int[] {469}, arg2: false);
                context.SetSkill(arg1: new int[] {470}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬27(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬27 : TriggerState {
            internal State스킬27(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new int[] {459}, arg2: true);
                context.SetSkill(arg1: new int[] {460}, arg2: true);
                context.SetSkill(arg1: new int[] {461}, arg2: true);
                context.SetSkill(arg1: new int[] {462}, arg2: true);
                context.SetSkill(arg1: new int[] {463}, arg2: true);
                context.SetSkill(arg1: new int[] {464}, arg2: true);
                context.SetSkill(arg1: new int[] {465}, arg2: true);
                context.SetSkill(arg1: new int[] {466}, arg2: true);
                context.SetSkill(arg1: new int[] {467}, arg2: true);
                context.SetSkill(arg1: new int[] {468}, arg2: true);
                context.SetSkill(arg1: new int[] {469}, arg2: true);
                context.SetSkill(arg1: new int[] {470}, arg2: true);
                context.SetSkill(arg1: new int[] {471}, arg2: true);
                context.SetSkill(arg1: new int[] {472}, arg2: true);
                context.SetSkill(arg1: new int[] {473}, arg2: true);
                context.SetSkill(arg1: new int[] {474}, arg2: true);
                context.SetSkill(arg1: new int[] {475}, arg2: true);
                context.SetSkill(arg1: new int[] {476}, arg2: true);
                context.SetSkill(arg1: new int[] {477}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬28대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬28대기 : TriggerState {
            internal State스킬28대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {459}, arg2: false);
                context.SetSkill(arg1: new int[] {460}, arg2: false);
                context.SetSkill(arg1: new int[] {461}, arg2: false);
                context.SetSkill(arg1: new int[] {462}, arg2: false);
                context.SetSkill(arg1: new int[] {463}, arg2: false);
                context.SetSkill(arg1: new int[] {464}, arg2: false);
                context.SetSkill(arg1: new int[] {465}, arg2: false);
                context.SetSkill(arg1: new int[] {466}, arg2: false);
                context.SetSkill(arg1: new int[] {467}, arg2: false);
                context.SetSkill(arg1: new int[] {468}, arg2: false);
                context.SetSkill(arg1: new int[] {469}, arg2: false);
                context.SetSkill(arg1: new int[] {470}, arg2: false);
                context.SetSkill(arg1: new int[] {471}, arg2: false);
                context.SetSkill(arg1: new int[] {472}, arg2: false);
                context.SetSkill(arg1: new int[] {473}, arg2: false);
                context.SetSkill(arg1: new int[] {474}, arg2: false);
                context.SetSkill(arg1: new int[] {475}, arg2: false);
                context.SetSkill(arg1: new int[] {476}, arg2: false);
                context.SetSkill(arg1: new int[] {477}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬28(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬28 : TriggerState {
            internal State스킬28(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new int[] {465}, arg2: true);
                context.SetSkill(arg1: new int[] {466}, arg2: true);
                context.SetSkill(arg1: new int[] {467}, arg2: true);
                context.SetSkill(arg1: new int[] {468}, arg2: true);
                context.SetSkill(arg1: new int[] {469}, arg2: true);
                context.SetSkill(arg1: new int[] {470}, arg2: true);
                context.SetSkill(arg1: new int[] {471}, arg2: true);
                context.SetSkill(arg1: new int[] {472}, arg2: true);
                context.SetSkill(arg1: new int[] {473}, arg2: true);
                context.SetSkill(arg1: new int[] {474}, arg2: true);
                context.SetSkill(arg1: new int[] {475}, arg2: true);
                context.SetSkill(arg1: new int[] {476}, arg2: true);
                context.SetSkill(arg1: new int[] {477}, arg2: true);
                context.SetSkill(arg1: new int[] {478}, arg2: true);
                context.SetSkill(arg1: new int[] {479}, arg2: true);
                context.SetSkill(arg1: new int[] {480}, arg2: true);
                context.SetSkill(arg1: new int[] {481}, arg2: true);
                context.SetSkill(arg1: new int[] {482}, arg2: true);
                context.SetSkill(arg1: new int[] {483}, arg2: true);
                context.SetSkill(arg1: new int[] {484}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬29대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬29대기 : TriggerState {
            internal State스킬29대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {465}, arg2: false);
                context.SetSkill(arg1: new int[] {466}, arg2: false);
                context.SetSkill(arg1: new int[] {467}, arg2: false);
                context.SetSkill(arg1: new int[] {468}, arg2: false);
                context.SetSkill(arg1: new int[] {469}, arg2: false);
                context.SetSkill(arg1: new int[] {470}, arg2: false);
                context.SetSkill(arg1: new int[] {471}, arg2: false);
                context.SetSkill(arg1: new int[] {472}, arg2: false);
                context.SetSkill(arg1: new int[] {473}, arg2: false);
                context.SetSkill(arg1: new int[] {474}, arg2: false);
                context.SetSkill(arg1: new int[] {475}, arg2: false);
                context.SetSkill(arg1: new int[] {476}, arg2: false);
                context.SetSkill(arg1: new int[] {477}, arg2: false);
                context.SetSkill(arg1: new int[] {478}, arg2: false);
                context.SetSkill(arg1: new int[] {479}, arg2: false);
                context.SetSkill(arg1: new int[] {480}, arg2: false);
                context.SetSkill(arg1: new int[] {481}, arg2: false);
                context.SetSkill(arg1: new int[] {482}, arg2: false);
                context.SetSkill(arg1: new int[] {483}, arg2: false);
                context.SetSkill(arg1: new int[] {484}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬29(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬29 : TriggerState {
            internal State스킬29(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new int[] {471}, arg2: true);
                context.SetSkill(arg1: new int[] {472}, arg2: true);
                context.SetSkill(arg1: new int[] {473}, arg2: true);
                context.SetSkill(arg1: new int[] {474}, arg2: true);
                context.SetSkill(arg1: new int[] {475}, arg2: true);
                context.SetSkill(arg1: new int[] {476}, arg2: true);
                context.SetSkill(arg1: new int[] {477}, arg2: true);
                context.SetSkill(arg1: new int[] {478}, arg2: true);
                context.SetSkill(arg1: new int[] {479}, arg2: true);
                context.SetSkill(arg1: new int[] {480}, arg2: true);
                context.SetSkill(arg1: new int[] {481}, arg2: true);
                context.SetSkill(arg1: new int[] {482}, arg2: true);
                context.SetSkill(arg1: new int[] {483}, arg2: true);
                context.SetSkill(arg1: new int[] {484}, arg2: true);
                context.SetSkill(arg1: new int[] {485}, arg2: true);
                context.SetSkill(arg1: new int[] {486}, arg2: true);
                context.SetSkill(arg1: new int[] {487}, arg2: true);
                context.SetSkill(arg1: new int[] {488}, arg2: true);
                context.SetSkill(arg1: new int[] {489}, arg2: true);
                context.SetSkill(arg1: new int[] {490}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬30대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬30대기 : TriggerState {
            internal State스킬30대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {471}, arg2: false);
                context.SetSkill(arg1: new int[] {472}, arg2: false);
                context.SetSkill(arg1: new int[] {473}, arg2: false);
                context.SetSkill(arg1: new int[] {474}, arg2: false);
                context.SetSkill(arg1: new int[] {475}, arg2: false);
                context.SetSkill(arg1: new int[] {476}, arg2: false);
                context.SetSkill(arg1: new int[] {477}, arg2: false);
                context.SetSkill(arg1: new int[] {478}, arg2: false);
                context.SetSkill(arg1: new int[] {479}, arg2: false);
                context.SetSkill(arg1: new int[] {480}, arg2: false);
                context.SetSkill(arg1: new int[] {481}, arg2: false);
                context.SetSkill(arg1: new int[] {482}, arg2: false);
                context.SetSkill(arg1: new int[] {483}, arg2: false);
                context.SetSkill(arg1: new int[] {484}, arg2: false);
                context.SetSkill(arg1: new int[] {485}, arg2: false);
                context.SetSkill(arg1: new int[] {486}, arg2: false);
                context.SetSkill(arg1: new int[] {487}, arg2: false);
                context.SetSkill(arg1: new int[] {488}, arg2: false);
                context.SetSkill(arg1: new int[] {489}, arg2: false);
                context.SetSkill(arg1: new int[] {490}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬30(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬30 : TriggerState {
            internal State스킬30(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new int[] {478}, arg2: true);
                context.SetSkill(arg1: new int[] {479}, arg2: true);
                context.SetSkill(arg1: new int[] {480}, arg2: true);
                context.SetSkill(arg1: new int[] {481}, arg2: true);
                context.SetSkill(arg1: new int[] {482}, arg2: true);
                context.SetSkill(arg1: new int[] {483}, arg2: true);
                context.SetSkill(arg1: new int[] {484}, arg2: true);
                context.SetSkill(arg1: new int[] {485}, arg2: true);
                context.SetSkill(arg1: new int[] {486}, arg2: true);
                context.SetSkill(arg1: new int[] {487}, arg2: true);
                context.SetSkill(arg1: new int[] {488}, arg2: true);
                context.SetSkill(arg1: new int[] {489}, arg2: true);
                context.SetSkill(arg1: new int[] {490}, arg2: true);
                context.SetSkill(arg1: new int[] {491}, arg2: true);
                context.SetSkill(arg1: new int[] {492}, arg2: true);
                context.SetSkill(arg1: new int[] {493}, arg2: true);
                context.SetSkill(arg1: new int[] {494}, arg2: true);
                context.SetSkill(arg1: new int[] {495}, arg2: true);
                context.SetSkill(arg1: new int[] {496}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬31대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬31대기 : TriggerState {
            internal State스킬31대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {478}, arg2: false);
                context.SetSkill(arg1: new int[] {479}, arg2: false);
                context.SetSkill(arg1: new int[] {480}, arg2: false);
                context.SetSkill(arg1: new int[] {481}, arg2: false);
                context.SetSkill(arg1: new int[] {482}, arg2: false);
                context.SetSkill(arg1: new int[] {483}, arg2: false);
                context.SetSkill(arg1: new int[] {484}, arg2: false);
                context.SetSkill(arg1: new int[] {485}, arg2: false);
                context.SetSkill(arg1: new int[] {486}, arg2: false);
                context.SetSkill(arg1: new int[] {487}, arg2: false);
                context.SetSkill(arg1: new int[] {488}, arg2: false);
                context.SetSkill(arg1: new int[] {489}, arg2: false);
                context.SetSkill(arg1: new int[] {490}, arg2: false);
                context.SetSkill(arg1: new int[] {491}, arg2: false);
                context.SetSkill(arg1: new int[] {492}, arg2: false);
                context.SetSkill(arg1: new int[] {493}, arg2: false);
                context.SetSkill(arg1: new int[] {494}, arg2: false);
                context.SetSkill(arg1: new int[] {495}, arg2: false);
                context.SetSkill(arg1: new int[] {496}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬31(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬31 : TriggerState {
            internal State스킬31(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new int[] {485}, arg2: true);
                context.SetSkill(arg1: new int[] {486}, arg2: true);
                context.SetSkill(arg1: new int[] {487}, arg2: true);
                context.SetSkill(arg1: new int[] {488}, arg2: true);
                context.SetSkill(arg1: new int[] {489}, arg2: true);
                context.SetSkill(arg1: new int[] {490}, arg2: true);
                context.SetSkill(arg1: new int[] {491}, arg2: true);
                context.SetSkill(arg1: new int[] {492}, arg2: true);
                context.SetSkill(arg1: new int[] {493}, arg2: true);
                context.SetSkill(arg1: new int[] {494}, arg2: true);
                context.SetSkill(arg1: new int[] {495}, arg2: true);
                context.SetSkill(arg1: new int[] {496}, arg2: true);
                context.SetSkill(arg1: new int[] {497}, arg2: true);
                context.SetSkill(arg1: new int[] {498}, arg2: true);
                context.SetSkill(arg1: new int[] {499}, arg2: true);
                context.SetSkill(arg1: new int[] {500}, arg2: true);
                context.SetSkill(arg1: new int[] {501}, arg2: true);
                context.SetSkill(arg1: new int[] {502}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬32대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬32대기 : TriggerState {
            internal State스킬32대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {485}, arg2: false);
                context.SetSkill(arg1: new int[] {486}, arg2: false);
                context.SetSkill(arg1: new int[] {487}, arg2: false);
                context.SetSkill(arg1: new int[] {488}, arg2: false);
                context.SetSkill(arg1: new int[] {489}, arg2: false);
                context.SetSkill(arg1: new int[] {490}, arg2: false);
                context.SetSkill(arg1: new int[] {491}, arg2: false);
                context.SetSkill(arg1: new int[] {492}, arg2: false);
                context.SetSkill(arg1: new int[] {493}, arg2: false);
                context.SetSkill(arg1: new int[] {494}, arg2: false);
                context.SetSkill(arg1: new int[] {495}, arg2: false);
                context.SetSkill(arg1: new int[] {496}, arg2: false);
                context.SetSkill(arg1: new int[] {497}, arg2: false);
                context.SetSkill(arg1: new int[] {498}, arg2: false);
                context.SetSkill(arg1: new int[] {499}, arg2: false);
                context.SetSkill(arg1: new int[] {500}, arg2: false);
                context.SetSkill(arg1: new int[] {501}, arg2: false);
                context.SetSkill(arg1: new int[] {502}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬32(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬32 : TriggerState {
            internal State스킬32(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new int[] {491}, arg2: true);
                context.SetSkill(arg1: new int[] {492}, arg2: true);
                context.SetSkill(arg1: new int[] {493}, arg2: true);
                context.SetSkill(arg1: new int[] {494}, arg2: true);
                context.SetSkill(arg1: new int[] {495}, arg2: true);
                context.SetSkill(arg1: new int[] {496}, arg2: true);
                context.SetSkill(arg1: new int[] {497}, arg2: true);
                context.SetSkill(arg1: new int[] {498}, arg2: true);
                context.SetSkill(arg1: new int[] {499}, arg2: true);
                context.SetSkill(arg1: new int[] {500}, arg2: true);
                context.SetSkill(arg1: new int[] {501}, arg2: true);
                context.SetSkill(arg1: new int[] {502}, arg2: true);
                context.SetSkill(arg1: new int[] {503}, arg2: true);
                context.SetSkill(arg1: new int[] {504}, arg2: true);
                context.SetSkill(arg1: new int[] {505}, arg2: true);
                context.SetSkill(arg1: new int[] {506}, arg2: true);
                context.SetSkill(arg1: new int[] {507}, arg2: true);
                context.SetSkill(arg1: new int[] {508}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬33대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬33대기 : TriggerState {
            internal State스킬33대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 0);
                context.SetSkill(arg1: new int[] {491}, arg2: false);
                context.SetSkill(arg1: new int[] {492}, arg2: false);
                context.SetSkill(arg1: new int[] {493}, arg2: false);
                context.SetSkill(arg1: new int[] {494}, arg2: false);
                context.SetSkill(arg1: new int[] {495}, arg2: false);
                context.SetSkill(arg1: new int[] {496}, arg2: false);
                context.SetSkill(arg1: new int[] {497}, arg2: false);
                context.SetSkill(arg1: new int[] {498}, arg2: false);
                context.SetSkill(arg1: new int[] {499}, arg2: false);
                context.SetSkill(arg1: new int[] {500}, arg2: false);
                context.SetSkill(arg1: new int[] {501}, arg2: false);
                context.SetSkill(arg1: new int[] {502}, arg2: false);
                context.SetSkill(arg1: new int[] {503}, arg2: false);
                context.SetSkill(arg1: new int[] {504}, arg2: false);
                context.SetSkill(arg1: new int[] {505}, arg2: false);
                context.SetSkill(arg1: new int[] {506}, arg2: false);
                context.SetSkill(arg1: new int[] {507}, arg2: false);
                context.SetSkill(arg1: new int[] {508}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬33(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬33 : TriggerState {
            internal State스킬33(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new int[] {497}, arg2: true);
                context.SetSkill(arg1: new int[] {498}, arg2: true);
                context.SetSkill(arg1: new int[] {499}, arg2: true);
                context.SetSkill(arg1: new int[] {500}, arg2: true);
                context.SetSkill(arg1: new int[] {501}, arg2: true);
                context.SetSkill(arg1: new int[] {502}, arg2: true);
                context.SetSkill(arg1: new int[] {503}, arg2: true);
                context.SetSkill(arg1: new int[] {504}, arg2: true);
                context.SetSkill(arg1: new int[] {505}, arg2: true);
                context.SetSkill(arg1: new int[] {506}, arg2: true);
                context.SetSkill(arg1: new int[] {507}, arg2: true);
                context.SetSkill(arg1: new int[] {508}, arg2: true);
                context.SetSkill(arg1: new int[] {509}, arg2: true);
                context.SetSkill(arg1: new int[] {510}, arg2: true);
                context.SetSkill(arg1: new int[] {511}, arg2: true);
                context.SetSkill(arg1: new int[] {512}, arg2: true);
                context.SetSkill(arg1: new int[] {513}, arg2: true);
                context.SetSkill(arg1: new int[] {514}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State끝(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State끝 : TriggerState {
            internal State끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {497}, arg2: false);
                context.SetSkill(arg1: new int[] {498}, arg2: false);
                context.SetSkill(arg1: new int[] {499}, arg2: false);
                context.SetSkill(arg1: new int[] {500}, arg2: false);
                context.SetSkill(arg1: new int[] {501}, arg2: false);
                context.SetSkill(arg1: new int[] {502}, arg2: false);
                context.SetSkill(arg1: new int[] {503}, arg2: false);
                context.SetSkill(arg1: new int[] {504}, arg2: false);
                context.SetSkill(arg1: new int[] {505}, arg2: false);
                context.SetSkill(arg1: new int[] {506}, arg2: false);
                context.SetSkill(arg1: new int[] {507}, arg2: false);
                context.SetSkill(arg1: new int[] {508}, arg2: false);
                context.SetSkill(arg1: new int[] {509}, arg2: false);
                context.SetSkill(arg1: new int[] {510}, arg2: false);
                context.SetSkill(arg1: new int[] {511}, arg2: false);
                context.SetSkill(arg1: new int[] {512}, arg2: false);
                context.SetSkill(arg1: new int[] {513}, arg2: false);
                context.SetSkill(arg1: new int[] {514}, arg2: false);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}