using Maple2.Trigger._dungeon_common;

namespace Maple2.Trigger._02000252_bf {
    public static class _start {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {151, 152, 153, 154, 155, 156}, arg2: true);
                context.SetEffect(arg1: new[] {601}, arg2: false);
                context.SetEffect(arg1: new[] {602}, arg2: false);
                context.SetEffect(arg1: new[] {603}, arg2: false);
                context.SetEffect(arg1: new[] {8001}, arg2: false);
                context.SetEffect(arg1: new[] {8002}, arg2: false);
                context.SetEffect(arg1: new[] {8003}, arg2: false);
                context.SetEffect(arg1: new[] {8004}, arg2: false);
                context.SetEffect(arg1: new[] {8005}, arg2: false);
                context.SetEffect(arg1: new[] {8006}, arg2: false);
                context.SetEffect(arg1: new[] {8007}, arg2: false);
                context.SetEffect(arg1: new[] {8008}, arg2: false);
                context.SetEffect(arg1: new[] {8009}, arg2: false);
                context.SetEffect(arg1: new[] {8010}, arg2: false);
                context.SetEffect(arg1: new[] {8011}, arg2: false);
                context.SetEffect(arg1: new[] {8012}, arg2: false);
            }

            public override void Execute() {
                if (context.GetUserCount() > 0) {
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
                context.HideGuideSummary(entityId: 20002521);
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
                context.CameraSelectPath(arg1: new[] {8801, 8802}, arg2: false);
                context.CreateMonster(arg1: new[] {1001});
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
                context.CameraSelectPath(arg1: new[] {8804}, arg2: true);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetAchievement(arg1: 999, arg2: "trigger", arg3: "Bellafirst");
                context.SetEffect(arg1: new[] {8001}, arg2: true);
                context.SetEffect(arg1: new[] {8002}, arg2: true);
                context.SetEffect(arg1: new[] {8003}, arg2: true);
                context.SetEffect(arg1: new[] {8004}, arg2: true);
                context.SetEffect(arg1: new[] {8005}, arg2: true);
                context.SetEffect(arg1: new[] {8006}, arg2: true);
                context.SetEffect(arg1: new[] {8007}, arg2: true);
                context.SetEffect(arg1: new[] {8008}, arg2: true);
                context.SetEffect(arg1: new[] {8009}, arg2: true);
                context.SetEffect(arg1: new[] {8010}, arg2: true);
                context.SetEffect(arg1: new[] {8011}, arg2: true);
                context.SetEffect(arg1: new[] {8012}, arg2: true);
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
                context.ShowGuideSummary(entityId: 20002522, textId: 20002522);
                context.SetMesh(arg1: new[] {151, 152, 153, 154, 155, 156}, arg2: false);
                context.CreateMonster(arg1: new[] {1051}, arg2: false);
                context.CreateMonster(arg1: new[] {1052}, arg2: false);
                context.CreateMonster(arg1: new[] {1053}, arg2: false);
                context.CreateMonster(arg1: new[] {1054}, arg2: false);
                context.CreateMonster(arg1: new[] {1055}, arg2: false);
                context.CreateMonster(arg1: new[] {1056}, arg2: false);
                context.CreateMonster(arg1: new[] {1057}, arg2: false);
                context.CreateMonster(arg1: new[] {1058}, arg2: false);
                context.CreateMonster(arg1: new[] {1059}, arg2: false);
                context.CreateMonster(arg1: new[] {1060}, arg2: false);
                context.CreateMonster(arg1: new[] {1061}, arg2: false);
                context.CreateMonster(arg1: new[] {1062}, arg2: false);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.DestroyMonster(arg1: new[] {1001});
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
                context.SetEffect(arg1: new[] {8001}, arg2: false);
                context.SetEffect(arg1: new[] {8002}, arg2: false);
                context.SetEffect(arg1: new[] {8003}, arg2: false);
                context.SetEffect(arg1: new[] {8004}, arg2: false);
                context.SetEffect(arg1: new[] {8005}, arg2: false);
                context.SetEffect(arg1: new[] {8006}, arg2: false);
                context.SetEffect(arg1: new[] {8007}, arg2: false);
                context.SetEffect(arg1: new[] {8008}, arg2: false);
                context.SetEffect(arg1: new[] {8009}, arg2: false);
                context.SetEffect(arg1: new[] {8010}, arg2: false);
                context.SetEffect(arg1: new[] {8011}, arg2: false);
                context.SetEffect(arg1: new[] {8012}, arg2: false);
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
                context.SetSkill(arg1: new[] {515}, arg2: true);
                context.SetSkill(arg1: new[] {516}, arg2: true);
                context.SetSkill(arg1: new[] {517}, arg2: true);
                context.SetSkill(arg1: new[] {518}, arg2: true);
                context.SetSkill(arg1: new[] {519}, arg2: true);
                context.SetSkill(arg1: new[] {520}, arg2: true);
                context.SetSkill(arg1: new[] {521}, arg2: true);
                context.SetSkill(arg1: new[] {522}, arg2: true);
                context.SetSkill(arg1: new[] {523}, arg2: true);
                context.SetSkill(arg1: new[] {524}, arg2: true);
                context.SetSkill(arg1: new[] {525}, arg2: true);
                context.SetSkill(arg1: new[] {526}, arg2: true);
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
                context.SetSkill(arg1: new[] {515}, arg2: false);
                context.SetSkill(arg1: new[] {516}, arg2: false);
                context.SetSkill(arg1: new[] {517}, arg2: false);
                context.SetSkill(arg1: new[] {518}, arg2: false);
                context.SetSkill(arg1: new[] {519}, arg2: false);
                context.SetSkill(arg1: new[] {520}, arg2: false);
                context.SetSkill(arg1: new[] {521}, arg2: false);
                context.SetSkill(arg1: new[] {522}, arg2: false);
                context.SetSkill(arg1: new[] {523}, arg2: false);
                context.SetSkill(arg1: new[] {524}, arg2: false);
                context.SetSkill(arg1: new[] {525}, arg2: false);
                context.SetSkill(arg1: new[] {526}, arg2: false);
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
                context.SetSkill(arg1: new[] {564}, arg2: true);
                context.SetSkill(arg1: new[] {517}, arg2: true);
                context.SetSkill(arg1: new[] {518}, arg2: true);
                context.SetSkill(arg1: new[] {519}, arg2: true);
                context.SetSkill(arg1: new[] {520}, arg2: true);
                context.SetSkill(arg1: new[] {521}, arg2: true);
                context.SetSkill(arg1: new[] {522}, arg2: true);
                context.SetSkill(arg1: new[] {523}, arg2: true);
                context.SetSkill(arg1: new[] {524}, arg2: true);
                context.SetSkill(arg1: new[] {525}, arg2: true);
                context.SetSkill(arg1: new[] {526}, arg2: true);
                context.SetSkill(arg1: new[] {527}, arg2: true);
                context.SetSkill(arg1: new[] {528}, arg2: true);
                context.SetSkill(arg1: new[] {529}, arg2: true);
                context.SetSkill(arg1: new[] {530}, arg2: true);
                context.SetSkill(arg1: new[] {531}, arg2: true);
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
                context.SetSkill(arg1: new[] {564}, arg2: false);
                context.SetSkill(arg1: new[] {517}, arg2: false);
                context.SetSkill(arg1: new[] {518}, arg2: false);
                context.SetSkill(arg1: new[] {519}, arg2: false);
                context.SetSkill(arg1: new[] {520}, arg2: false);
                context.SetSkill(arg1: new[] {521}, arg2: false);
                context.SetSkill(arg1: new[] {522}, arg2: false);
                context.SetSkill(arg1: new[] {523}, arg2: false);
                context.SetSkill(arg1: new[] {524}, arg2: false);
                context.SetSkill(arg1: new[] {525}, arg2: false);
                context.SetSkill(arg1: new[] {526}, arg2: false);
                context.SetSkill(arg1: new[] {527}, arg2: false);
                context.SetSkill(arg1: new[] {528}, arg2: false);
                context.SetSkill(arg1: new[] {529}, arg2: false);
                context.SetSkill(arg1: new[] {530}, arg2: false);
                context.SetSkill(arg1: new[] {531}, arg2: false);
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
                context.SetSkill(arg1: new[] {565}, arg2: true);
                context.SetSkill(arg1: new[] {564}, arg2: true);
                context.SetSkill(arg1: new[] {522}, arg2: true);
                context.SetSkill(arg1: new[] {523}, arg2: true);
                context.SetSkill(arg1: new[] {524}, arg2: true);
                context.SetSkill(arg1: new[] {525}, arg2: true);
                context.SetSkill(arg1: new[] {526}, arg2: true);
                context.SetSkill(arg1: new[] {527}, arg2: true);
                context.SetSkill(arg1: new[] {528}, arg2: true);
                context.SetSkill(arg1: new[] {529}, arg2: true);
                context.SetSkill(arg1: new[] {530}, arg2: true);
                context.SetSkill(arg1: new[] {531}, arg2: true);
                context.SetSkill(arg1: new[] {532}, arg2: true);
                context.SetSkill(arg1: new[] {533}, arg2: true);
                context.SetSkill(arg1: new[] {534}, arg2: true);
                context.SetSkill(arg1: new[] {535}, arg2: true);
                context.SetSkill(arg1: new[] {536}, arg2: true);
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
                context.HideGuideSummary(entityId: 20002522);
                context.SetSkill(arg1: new[] {565}, arg2: false);
                context.SetSkill(arg1: new[] {564}, arg2: false);
                context.SetSkill(arg1: new[] {522}, arg2: false);
                context.SetSkill(arg1: new[] {523}, arg2: false);
                context.SetSkill(arg1: new[] {524}, arg2: false);
                context.SetSkill(arg1: new[] {525}, arg2: false);
                context.SetSkill(arg1: new[] {526}, arg2: false);
                context.SetSkill(arg1: new[] {527}, arg2: false);
                context.SetSkill(arg1: new[] {528}, arg2: false);
                context.SetSkill(arg1: new[] {529}, arg2: false);
                context.SetSkill(arg1: new[] {530}, arg2: false);
                context.SetSkill(arg1: new[] {531}, arg2: false);
                context.SetSkill(arg1: new[] {532}, arg2: false);
                context.SetSkill(arg1: new[] {533}, arg2: false);
                context.SetSkill(arg1: new[] {534}, arg2: false);
                context.SetSkill(arg1: new[] {535}, arg2: false);
                context.SetSkill(arg1: new[] {536}, arg2: false);
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
                context.SetSkill(arg1: new[] {566}, arg2: true);
                context.SetSkill(arg1: new[] {567}, arg2: true);
                context.SetSkill(arg1: new[] {568}, arg2: true);
                context.SetSkill(arg1: new[] {565}, arg2: true);
                context.SetSkill(arg1: new[] {564}, arg2: true);
                context.SetSkill(arg1: new[] {527}, arg2: true);
                context.SetSkill(arg1: new[] {528}, arg2: true);
                context.SetSkill(arg1: new[] {529}, arg2: true);
                context.SetSkill(arg1: new[] {530}, arg2: true);
                context.SetSkill(arg1: new[] {531}, arg2: true);
                context.SetSkill(arg1: new[] {532}, arg2: true);
                context.SetSkill(arg1: new[] {533}, arg2: true);
                context.SetSkill(arg1: new[] {534}, arg2: true);
                context.SetSkill(arg1: new[] {535}, arg2: true);
                context.SetSkill(arg1: new[] {536}, arg2: true);
                context.SetSkill(arg1: new[] {537}, arg2: true);
                context.SetSkill(arg1: new[] {538}, arg2: true);
                context.SetSkill(arg1: new[] {539}, arg2: true);
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
                context.SetSkill(arg1: new[] {566}, arg2: false);
                context.SetSkill(arg1: new[] {567}, arg2: false);
                context.SetSkill(arg1: new[] {568}, arg2: false);
                context.SetSkill(arg1: new[] {565}, arg2: false);
                context.SetSkill(arg1: new[] {564}, arg2: false);
                context.SetSkill(arg1: new[] {527}, arg2: false);
                context.SetSkill(arg1: new[] {528}, arg2: false);
                context.SetSkill(arg1: new[] {529}, arg2: false);
                context.SetSkill(arg1: new[] {530}, arg2: false);
                context.SetSkill(arg1: new[] {531}, arg2: false);
                context.SetSkill(arg1: new[] {532}, arg2: false);
                context.SetSkill(arg1: new[] {533}, arg2: false);
                context.SetSkill(arg1: new[] {534}, arg2: false);
                context.SetSkill(arg1: new[] {535}, arg2: false);
                context.SetSkill(arg1: new[] {536}, arg2: false);
                context.SetSkill(arg1: new[] {537}, arg2: false);
                context.SetSkill(arg1: new[] {538}, arg2: false);
                context.SetSkill(arg1: new[] {539}, arg2: false);
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
                context.SetSkill(arg1: new[] {566}, arg2: false);
                context.SetSkill(arg1: new[] {567}, arg2: false);
                context.SetSkill(arg1: new[] {568}, arg2: false);
                context.SetSkill(arg1: new[] {565}, arg2: true);
                context.SetSkill(arg1: new[] {532}, arg2: true);
                context.SetSkill(arg1: new[] {533}, arg2: true);
                context.SetSkill(arg1: new[] {534}, arg2: true);
                context.SetSkill(arg1: new[] {535}, arg2: true);
                context.SetSkill(arg1: new[] {536}, arg2: true);
                context.SetSkill(arg1: new[] {537}, arg2: true);
                context.SetSkill(arg1: new[] {538}, arg2: true);
                context.SetSkill(arg1: new[] {539}, arg2: true);
                context.SetSkill(arg1: new[] {540}, arg2: true);
                context.SetSkill(arg1: new[] {541}, arg2: true);
                context.SetSkill(arg1: new[] {542}, arg2: true);
                context.SetSkill(arg1: new[] {543}, arg2: true);
                context.SetSkill(arg1: new[] {544}, arg2: true);
                context.SetSkill(arg1: new[] {545}, arg2: true);
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
                context.SetSkill(arg1: new[] {566}, arg2: false);
                context.SetSkill(arg1: new[] {567}, arg2: false);
                context.SetSkill(arg1: new[] {568}, arg2: false);
                context.SetSkill(arg1: new[] {565}, arg2: false);
                context.SetSkill(arg1: new[] {532}, arg2: false);
                context.SetSkill(arg1: new[] {533}, arg2: false);
                context.SetSkill(arg1: new[] {534}, arg2: false);
                context.SetSkill(arg1: new[] {535}, arg2: false);
                context.SetSkill(arg1: new[] {536}, arg2: false);
                context.SetSkill(arg1: new[] {537}, arg2: false);
                context.SetSkill(arg1: new[] {538}, arg2: false);
                context.SetSkill(arg1: new[] {539}, arg2: false);
                context.SetSkill(arg1: new[] {540}, arg2: false);
                context.SetSkill(arg1: new[] {541}, arg2: false);
                context.SetSkill(arg1: new[] {542}, arg2: false);
                context.SetSkill(arg1: new[] {543}, arg2: false);
                context.SetSkill(arg1: new[] {544}, arg2: false);
                context.SetSkill(arg1: new[] {545}, arg2: false);
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
                context.SetSkill(arg1: new[] {566}, arg2: true);
                context.SetSkill(arg1: new[] {567}, arg2: true);
                context.SetSkill(arg1: new[] {568}, arg2: true);
                context.SetSkill(arg1: new[] {537}, arg2: true);
                context.SetSkill(arg1: new[] {538}, arg2: true);
                context.SetSkill(arg1: new[] {539}, arg2: true);
                context.SetSkill(arg1: new[] {540}, arg2: true);
                context.SetSkill(arg1: new[] {541}, arg2: true);
                context.SetSkill(arg1: new[] {542}, arg2: true);
                context.SetSkill(arg1: new[] {543}, arg2: true);
                context.SetSkill(arg1: new[] {544}, arg2: true);
                context.SetSkill(arg1: new[] {545}, arg2: true);
                context.SetSkill(arg1: new[] {546}, arg2: true);
                context.SetSkill(arg1: new[] {547}, arg2: true);
                context.SetSkill(arg1: new[] {548}, arg2: true);
                context.SetSkill(arg1: new[] {549}, arg2: true);
                context.SetSkill(arg1: new[] {550}, arg2: true);
                context.SetSkill(arg1: new[] {551}, arg2: true);
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
                context.SetSkill(arg1: new[] {566}, arg2: false);
                context.SetSkill(arg1: new[] {567}, arg2: false);
                context.SetSkill(arg1: new[] {568}, arg2: false);
                context.SetSkill(arg1: new[] {537}, arg2: false);
                context.SetSkill(arg1: new[] {538}, arg2: false);
                context.SetSkill(arg1: new[] {539}, arg2: false);
                context.SetSkill(arg1: new[] {540}, arg2: false);
                context.SetSkill(arg1: new[] {541}, arg2: false);
                context.SetSkill(arg1: new[] {542}, arg2: false);
                context.SetSkill(arg1: new[] {543}, arg2: false);
                context.SetSkill(arg1: new[] {544}, arg2: false);
                context.SetSkill(arg1: new[] {545}, arg2: false);
                context.SetSkill(arg1: new[] {546}, arg2: false);
                context.SetSkill(arg1: new[] {547}, arg2: false);
                context.SetSkill(arg1: new[] {548}, arg2: false);
                context.SetSkill(arg1: new[] {549}, arg2: false);
                context.SetSkill(arg1: new[] {550}, arg2: false);
                context.SetSkill(arg1: new[] {551}, arg2: false);
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
                context.SetSkill(arg1: new[] {540}, arg2: true);
                context.SetSkill(arg1: new[] {541}, arg2: true);
                context.SetSkill(arg1: new[] {542}, arg2: true);
                context.SetSkill(arg1: new[] {543}, arg2: true);
                context.SetSkill(arg1: new[] {544}, arg2: true);
                context.SetSkill(arg1: new[] {545}, arg2: true);
                context.SetSkill(arg1: new[] {546}, arg2: true);
                context.SetSkill(arg1: new[] {547}, arg2: true);
                context.SetSkill(arg1: new[] {548}, arg2: true);
                context.SetSkill(arg1: new[] {549}, arg2: true);
                context.SetSkill(arg1: new[] {550}, arg2: true);
                context.SetSkill(arg1: new[] {551}, arg2: true);
                context.SetSkill(arg1: new[] {552}, arg2: true);
                context.SetSkill(arg1: new[] {553}, arg2: true);
                context.SetSkill(arg1: new[] {554}, arg2: true);
                context.SetSkill(arg1: new[] {555}, arg2: true);
                context.SetSkill(arg1: new[] {556}, arg2: true);
                context.SetSkill(arg1: new[] {557}, arg2: true);
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
                context.SetSkill(arg1: new[] {540}, arg2: false);
                context.SetSkill(arg1: new[] {541}, arg2: false);
                context.SetSkill(arg1: new[] {542}, arg2: false);
                context.SetSkill(arg1: new[] {543}, arg2: false);
                context.SetSkill(arg1: new[] {544}, arg2: false);
                context.SetSkill(arg1: new[] {545}, arg2: false);
                context.SetSkill(arg1: new[] {546}, arg2: false);
                context.SetSkill(arg1: new[] {547}, arg2: false);
                context.SetSkill(arg1: new[] {548}, arg2: false);
                context.SetSkill(arg1: new[] {549}, arg2: false);
                context.SetSkill(arg1: new[] {550}, arg2: false);
                context.SetSkill(arg1: new[] {551}, arg2: false);
                context.SetSkill(arg1: new[] {552}, arg2: false);
                context.SetSkill(arg1: new[] {553}, arg2: false);
                context.SetSkill(arg1: new[] {554}, arg2: false);
                context.SetSkill(arg1: new[] {555}, arg2: false);
                context.SetSkill(arg1: new[] {556}, arg2: false);
                context.SetSkill(arg1: new[] {557}, arg2: false);
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
                context.SetSkill(arg1: new[] {546}, arg2: true);
                context.SetSkill(arg1: new[] {547}, arg2: true);
                context.SetSkill(arg1: new[] {548}, arg2: true);
                context.SetSkill(arg1: new[] {549}, arg2: true);
                context.SetSkill(arg1: new[] {550}, arg2: true);
                context.SetSkill(arg1: new[] {551}, arg2: true);
                context.SetSkill(arg1: new[] {552}, arg2: true);
                context.SetSkill(arg1: new[] {553}, arg2: true);
                context.SetSkill(arg1: new[] {554}, arg2: true);
                context.SetSkill(arg1: new[] {555}, arg2: true);
                context.SetSkill(arg1: new[] {556}, arg2: true);
                context.SetSkill(arg1: new[] {557}, arg2: true);
                context.SetSkill(arg1: new[] {558}, arg2: true);
                context.SetSkill(arg1: new[] {559}, arg2: true);
                context.SetSkill(arg1: new[] {560}, arg2: true);
                context.SetSkill(arg1: new[] {561}, arg2: true);
                context.SetSkill(arg1: new[] {562}, arg2: true);
                context.SetSkill(arg1: new[] {563}, arg2: true);
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
                context.SetSkill(arg1: new[] {546}, arg2: false);
                context.SetSkill(arg1: new[] {547}, arg2: false);
                context.SetSkill(arg1: new[] {548}, arg2: false);
                context.SetSkill(arg1: new[] {549}, arg2: false);
                context.SetSkill(arg1: new[] {550}, arg2: false);
                context.SetSkill(arg1: new[] {551}, arg2: false);
                context.SetSkill(arg1: new[] {552}, arg2: false);
                context.SetSkill(arg1: new[] {553}, arg2: false);
                context.SetSkill(arg1: new[] {554}, arg2: false);
                context.SetSkill(arg1: new[] {555}, arg2: false);
                context.SetSkill(arg1: new[] {556}, arg2: false);
                context.SetSkill(arg1: new[] {557}, arg2: false);
                context.SetSkill(arg1: new[] {558}, arg2: false);
                context.SetSkill(arg1: new[] {559}, arg2: false);
                context.SetSkill(arg1: new[] {560}, arg2: false);
                context.SetSkill(arg1: new[] {561}, arg2: false);
                context.SetSkill(arg1: new[] {562}, arg2: false);
                context.SetSkill(arg1: new[] {563}, arg2: false);
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
                context.SetSkill(arg1: new[] {552}, arg2: true);
                context.SetSkill(arg1: new[] {553}, arg2: true);
                context.SetSkill(arg1: new[] {554}, arg2: true);
                context.SetSkill(arg1: new[] {555}, arg2: true);
                context.SetSkill(arg1: new[] {556}, arg2: true);
                context.SetSkill(arg1: new[] {557}, arg2: true);
                context.SetSkill(arg1: new[] {558}, arg2: true);
                context.SetSkill(arg1: new[] {559}, arg2: true);
                context.SetSkill(arg1: new[] {560}, arg2: true);
                context.SetSkill(arg1: new[] {561}, arg2: true);
                context.SetSkill(arg1: new[] {562}, arg2: true);
                context.SetSkill(arg1: new[] {563}, arg2: true);
                context.SetSkill(arg1: new[] {301}, arg2: true);
                context.SetSkill(arg1: new[] {302}, arg2: true);
                context.SetSkill(arg1: new[] {303}, arg2: true);
                context.SetSkill(arg1: new[] {304}, arg2: true);
                context.SetSkill(arg1: new[] {305}, arg2: true);
                context.SetSkill(arg1: new[] {306}, arg2: true);
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
                context.SetSkill(arg1: new[] {552}, arg2: false);
                context.SetSkill(arg1: new[] {553}, arg2: false);
                context.SetSkill(arg1: new[] {554}, arg2: false);
                context.SetSkill(arg1: new[] {555}, arg2: false);
                context.SetSkill(arg1: new[] {556}, arg2: false);
                context.SetSkill(arg1: new[] {557}, arg2: false);
                context.SetSkill(arg1: new[] {558}, arg2: false);
                context.SetSkill(arg1: new[] {559}, arg2: false);
                context.SetSkill(arg1: new[] {560}, arg2: false);
                context.SetSkill(arg1: new[] {561}, arg2: false);
                context.SetSkill(arg1: new[] {562}, arg2: false);
                context.SetSkill(arg1: new[] {563}, arg2: false);
                context.SetSkill(arg1: new[] {301}, arg2: false);
                context.SetSkill(arg1: new[] {302}, arg2: false);
                context.SetSkill(arg1: new[] {303}, arg2: false);
                context.SetSkill(arg1: new[] {304}, arg2: false);
                context.SetSkill(arg1: new[] {305}, arg2: false);
                context.SetSkill(arg1: new[] {306}, arg2: false);
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
                context.SetSkill(arg1: new[] {558}, arg2: true);
                context.SetSkill(arg1: new[] {559}, arg2: true);
                context.SetSkill(arg1: new[] {560}, arg2: true);
                context.SetSkill(arg1: new[] {561}, arg2: true);
                context.SetSkill(arg1: new[] {562}, arg2: true);
                context.SetSkill(arg1: new[] {563}, arg2: true);
                context.SetSkill(arg1: new[] {301}, arg2: true);
                context.SetSkill(arg1: new[] {302}, arg2: true);
                context.SetSkill(arg1: new[] {303}, arg2: true);
                context.SetSkill(arg1: new[] {304}, arg2: true);
                context.SetSkill(arg1: new[] {305}, arg2: true);
                context.SetSkill(arg1: new[] {306}, arg2: true);
                context.SetSkill(arg1: new[] {307}, arg2: true);
                context.SetSkill(arg1: new[] {308}, arg2: true);
                context.SetSkill(arg1: new[] {309}, arg2: true);
                context.SetSkill(arg1: new[] {310}, arg2: true);
                context.SetSkill(arg1: new[] {311}, arg2: true);
                context.SetSkill(arg1: new[] {312}, arg2: true);
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
                context.SetSkill(arg1: new[] {341}, arg2: false);
                context.SetSkill(arg1: new[] {342}, arg2: false);
                context.SetSkill(arg1: new[] {343}, arg2: false);
                context.SetSkill(arg1: new[] {344}, arg2: false);
                context.SetSkill(arg1: new[] {345}, arg2: false);
                context.SetSkill(arg1: new[] {346}, arg2: false);
                context.SetSkill(arg1: new[] {347}, arg2: false);
                context.SetSkill(arg1: new[] {348}, arg2: false);
                context.SetSkill(arg1: new[] {349}, arg2: false);
                context.SetSkill(arg1: new[] {350}, arg2: false);
                context.SetSkill(arg1: new[] {351}, arg2: false);
                context.SetSkill(arg1: new[] {352}, arg2: false);
                context.SetSkill(arg1: new[] {353}, arg2: false);
                context.SetSkill(arg1: new[] {354}, arg2: false);
                context.SetSkill(arg1: new[] {355}, arg2: false);
                context.SetSkill(arg1: new[] {356}, arg2: false);
                context.SetSkill(arg1: new[] {357}, arg2: false);
                context.SetSkill(arg1: new[] {358}, arg2: false);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000409}, arg2: 0)) {
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
                context.SetSkill(arg1: new[] {347}, arg2: false);
                context.SetSkill(arg1: new[] {348}, arg2: false);
                context.SetSkill(arg1: new[] {349}, arg2: false);
                context.SetSkill(arg1: new[] {350}, arg2: false);
                context.SetSkill(arg1: new[] {351}, arg2: false);
                context.SetSkill(arg1: new[] {352}, arg2: false);
                context.SetSkill(arg1: new[] {353}, arg2: false);
                context.SetSkill(arg1: new[] {354}, arg2: false);
                context.SetSkill(arg1: new[] {355}, arg2: false);
                context.SetSkill(arg1: new[] {356}, arg2: false);
                context.SetSkill(arg1: new[] {357}, arg2: false);
                context.SetSkill(arg1: new[] {358}, arg2: false);
                context.SetSkill(arg1: new[] {359}, arg2: false);
                context.SetSkill(arg1: new[] {360}, arg2: false);
                context.SetSkill(arg1: new[] {361}, arg2: false);
                context.SetSkill(arg1: new[] {362}, arg2: false);
                context.SetSkill(arg1: new[] {363}, arg2: false);
                context.SetSkill(arg1: new[] {364}, arg2: false);
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
                context.SetSkill(arg1: new[] {353}, arg2: true);
                context.SetSkill(arg1: new[] {354}, arg2: true);
                context.SetSkill(arg1: new[] {355}, arg2: true);
                context.SetSkill(arg1: new[] {356}, arg2: true);
                context.SetSkill(arg1: new[] {357}, arg2: true);
                context.SetSkill(arg1: new[] {358}, arg2: true);
                context.SetSkill(arg1: new[] {359}, arg2: true);
                context.SetSkill(arg1: new[] {360}, arg2: true);
                context.SetSkill(arg1: new[] {361}, arg2: true);
                context.SetSkill(arg1: new[] {362}, arg2: true);
                context.SetSkill(arg1: new[] {363}, arg2: true);
                context.SetSkill(arg1: new[] {364}, arg2: true);
                context.SetSkill(arg1: new[] {365}, arg2: true);
                context.SetSkill(arg1: new[] {366}, arg2: true);
                context.SetSkill(arg1: new[] {367}, arg2: true);
                context.SetSkill(arg1: new[] {368}, arg2: true);
                context.SetSkill(arg1: new[] {369}, arg2: true);
                context.SetSkill(arg1: new[] {370}, arg2: true);
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
                context.SetSkill(arg1: new[] {353}, arg2: false);
                context.SetSkill(arg1: new[] {354}, arg2: false);
                context.SetSkill(arg1: new[] {355}, arg2: false);
                context.SetSkill(arg1: new[] {356}, arg2: false);
                context.SetSkill(arg1: new[] {357}, arg2: false);
                context.SetSkill(arg1: new[] {358}, arg2: false);
                context.SetSkill(arg1: new[] {359}, arg2: false);
                context.SetSkill(arg1: new[] {360}, arg2: false);
                context.SetSkill(arg1: new[] {361}, arg2: false);
                context.SetSkill(arg1: new[] {362}, arg2: false);
                context.SetSkill(arg1: new[] {363}, arg2: false);
                context.SetSkill(arg1: new[] {364}, arg2: false);
                context.SetSkill(arg1: new[] {365}, arg2: false);
                context.SetSkill(arg1: new[] {366}, arg2: false);
                context.SetSkill(arg1: new[] {367}, arg2: false);
                context.SetSkill(arg1: new[] {368}, arg2: false);
                context.SetSkill(arg1: new[] {369}, arg2: false);
                context.SetSkill(arg1: new[] {370}, arg2: false);
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
                context.SetSkill(arg1: new[] {359}, arg2: true);
                context.SetSkill(arg1: new[] {360}, arg2: true);
                context.SetSkill(arg1: new[] {361}, arg2: true);
                context.SetSkill(arg1: new[] {362}, arg2: true);
                context.SetSkill(arg1: new[] {363}, arg2: true);
                context.SetSkill(arg1: new[] {364}, arg2: true);
                context.SetSkill(arg1: new[] {365}, arg2: true);
                context.SetSkill(arg1: new[] {366}, arg2: true);
                context.SetSkill(arg1: new[] {367}, arg2: true);
                context.SetSkill(arg1: new[] {368}, arg2: true);
                context.SetSkill(arg1: new[] {369}, arg2: true);
                context.SetSkill(arg1: new[] {370}, arg2: true);
                context.SetSkill(arg1: new[] {371}, arg2: true);
                context.SetSkill(arg1: new[] {372}, arg2: true);
                context.SetSkill(arg1: new[] {373}, arg2: true);
                context.SetSkill(arg1: new[] {374}, arg2: true);
                context.SetSkill(arg1: new[] {375}, arg2: true);
                context.SetSkill(arg1: new[] {376}, arg2: true);
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
                context.SetSkill(arg1: new[] {359}, arg2: false);
                context.SetSkill(arg1: new[] {360}, arg2: false);
                context.SetSkill(arg1: new[] {361}, arg2: false);
                context.SetSkill(arg1: new[] {362}, arg2: false);
                context.SetSkill(arg1: new[] {363}, arg2: false);
                context.SetSkill(arg1: new[] {364}, arg2: false);
                context.SetSkill(arg1: new[] {365}, arg2: false);
                context.SetSkill(arg1: new[] {366}, arg2: false);
                context.SetSkill(arg1: new[] {367}, arg2: false);
                context.SetSkill(arg1: new[] {368}, arg2: false);
                context.SetSkill(arg1: new[] {369}, arg2: false);
                context.SetSkill(arg1: new[] {370}, arg2: false);
                context.SetSkill(arg1: new[] {371}, arg2: false);
                context.SetSkill(arg1: new[] {372}, arg2: false);
                context.SetSkill(arg1: new[] {373}, arg2: false);
                context.SetSkill(arg1: new[] {374}, arg2: false);
                context.SetSkill(arg1: new[] {375}, arg2: false);
                context.SetSkill(arg1: new[] {376}, arg2: false);
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
                context.SetSkill(arg1: new[] {365}, arg2: true);
                context.SetSkill(arg1: new[] {366}, arg2: true);
                context.SetSkill(arg1: new[] {367}, arg2: true);
                context.SetSkill(arg1: new[] {368}, arg2: true);
                context.SetSkill(arg1: new[] {369}, arg2: true);
                context.SetSkill(arg1: new[] {370}, arg2: true);
                context.SetSkill(arg1: new[] {371}, arg2: true);
                context.SetSkill(arg1: new[] {372}, arg2: true);
                context.SetSkill(arg1: new[] {373}, arg2: true);
                context.SetSkill(arg1: new[] {374}, arg2: true);
                context.SetSkill(arg1: new[] {375}, arg2: true);
                context.SetSkill(arg1: new[] {376}, arg2: true);
                context.SetSkill(arg1: new[] {377}, arg2: true);
                context.SetSkill(arg1: new[] {378}, arg2: true);
                context.SetSkill(arg1: new[] {379}, arg2: true);
                context.SetSkill(arg1: new[] {380}, arg2: true);
                context.SetSkill(arg1: new[] {381}, arg2: true);
                context.SetSkill(arg1: new[] {382}, arg2: true);
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
                context.SetSkill(arg1: new[] {365}, arg2: false);
                context.SetSkill(arg1: new[] {366}, arg2: false);
                context.SetSkill(arg1: new[] {367}, arg2: false);
                context.SetSkill(arg1: new[] {368}, arg2: false);
                context.SetSkill(arg1: new[] {369}, arg2: false);
                context.SetSkill(arg1: new[] {370}, arg2: false);
                context.SetSkill(arg1: new[] {371}, arg2: false);
                context.SetSkill(arg1: new[] {372}, arg2: false);
                context.SetSkill(arg1: new[] {373}, arg2: false);
                context.SetSkill(arg1: new[] {374}, arg2: false);
                context.SetSkill(arg1: new[] {375}, arg2: false);
                context.SetSkill(arg1: new[] {376}, arg2: false);
                context.SetSkill(arg1: new[] {377}, arg2: false);
                context.SetSkill(arg1: new[] {378}, arg2: false);
                context.SetSkill(arg1: new[] {379}, arg2: false);
                context.SetSkill(arg1: new[] {380}, arg2: false);
                context.SetSkill(arg1: new[] {381}, arg2: false);
                context.SetSkill(arg1: new[] {382}, arg2: false);
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
                context.SetSkill(arg1: new[] {371}, arg2: true);
                context.SetSkill(arg1: new[] {372}, arg2: true);
                context.SetSkill(arg1: new[] {373}, arg2: true);
                context.SetSkill(arg1: new[] {374}, arg2: true);
                context.SetSkill(arg1: new[] {375}, arg2: true);
                context.SetSkill(arg1: new[] {376}, arg2: true);
                context.SetSkill(arg1: new[] {377}, arg2: true);
                context.SetSkill(arg1: new[] {378}, arg2: true);
                context.SetSkill(arg1: new[] {379}, arg2: true);
                context.SetSkill(arg1: new[] {380}, arg2: true);
                context.SetSkill(arg1: new[] {381}, arg2: true);
                context.SetSkill(arg1: new[] {382}, arg2: true);
                context.SetSkill(arg1: new[] {383}, arg2: true);
                context.SetSkill(arg1: new[] {384}, arg2: true);
                context.SetSkill(arg1: new[] {385}, arg2: true);
                context.SetSkill(arg1: new[] {386}, arg2: true);
                context.SetSkill(arg1: new[] {387}, arg2: true);
                context.SetSkill(arg1: new[] {388}, arg2: true);
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
                context.SetSkill(arg1: new[] {371}, arg2: false);
                context.SetSkill(arg1: new[] {372}, arg2: false);
                context.SetSkill(arg1: new[] {373}, arg2: false);
                context.SetSkill(arg1: new[] {374}, arg2: false);
                context.SetSkill(arg1: new[] {375}, arg2: false);
                context.SetSkill(arg1: new[] {376}, arg2: false);
                context.SetSkill(arg1: new[] {377}, arg2: false);
                context.SetSkill(arg1: new[] {378}, arg2: false);
                context.SetSkill(arg1: new[] {379}, arg2: false);
                context.SetSkill(arg1: new[] {380}, arg2: false);
                context.SetSkill(arg1: new[] {381}, arg2: false);
                context.SetSkill(arg1: new[] {382}, arg2: false);
                context.SetSkill(arg1: new[] {383}, arg2: false);
                context.SetSkill(arg1: new[] {384}, arg2: false);
                context.SetSkill(arg1: new[] {385}, arg2: false);
                context.SetSkill(arg1: new[] {386}, arg2: false);
                context.SetSkill(arg1: new[] {387}, arg2: false);
                context.SetSkill(arg1: new[] {388}, arg2: false);
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
                context.SetSkill(arg1: new[] {377}, arg2: true);
                context.SetSkill(arg1: new[] {378}, arg2: true);
                context.SetSkill(arg1: new[] {379}, arg2: true);
                context.SetSkill(arg1: new[] {380}, arg2: true);
                context.SetSkill(arg1: new[] {381}, arg2: true);
                context.SetSkill(arg1: new[] {382}, arg2: true);
                context.SetSkill(arg1: new[] {383}, arg2: true);
                context.SetSkill(arg1: new[] {384}, arg2: true);
                context.SetSkill(arg1: new[] {385}, arg2: true);
                context.SetSkill(arg1: new[] {386}, arg2: true);
                context.SetSkill(arg1: new[] {387}, arg2: true);
                context.SetSkill(arg1: new[] {388}, arg2: true);
                context.SetSkill(arg1: new[] {389}, arg2: true);
                context.SetSkill(arg1: new[] {390}, arg2: true);
                context.SetSkill(arg1: new[] {391}, arg2: true);
                context.SetSkill(arg1: new[] {392}, arg2: true);
                context.SetSkill(arg1: new[] {393}, arg2: true);
                context.SetSkill(arg1: new[] {394}, arg2: true);
                context.SetSkill(arg1: new[] {395}, arg2: true);
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
                context.SetSkill(arg1: new[] {377}, arg2: false);
                context.SetSkill(arg1: new[] {378}, arg2: false);
                context.SetSkill(arg1: new[] {379}, arg2: false);
                context.SetSkill(arg1: new[] {380}, arg2: false);
                context.SetSkill(arg1: new[] {381}, arg2: false);
                context.SetSkill(arg1: new[] {382}, arg2: false);
                context.SetSkill(arg1: new[] {383}, arg2: false);
                context.SetSkill(arg1: new[] {384}, arg2: false);
                context.SetSkill(arg1: new[] {385}, arg2: false);
                context.SetSkill(arg1: new[] {386}, arg2: false);
                context.SetSkill(arg1: new[] {387}, arg2: false);
                context.SetSkill(arg1: new[] {388}, arg2: false);
                context.SetSkill(arg1: new[] {389}, arg2: false);
                context.SetSkill(arg1: new[] {390}, arg2: false);
                context.SetSkill(arg1: new[] {391}, arg2: false);
                context.SetSkill(arg1: new[] {392}, arg2: false);
                context.SetSkill(arg1: new[] {393}, arg2: false);
                context.SetSkill(arg1: new[] {394}, arg2: false);
                context.SetSkill(arg1: new[] {395}, arg2: false);
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
                context.SetSkill(arg1: new[] {383}, arg2: true);
                context.SetSkill(arg1: new[] {384}, arg2: true);
                context.SetSkill(arg1: new[] {385}, arg2: true);
                context.SetSkill(arg1: new[] {386}, arg2: true);
                context.SetSkill(arg1: new[] {387}, arg2: true);
                context.SetSkill(arg1: new[] {388}, arg2: true);
                context.SetSkill(arg1: new[] {389}, arg2: true);
                context.SetSkill(arg1: new[] {390}, arg2: true);
                context.SetSkill(arg1: new[] {391}, arg2: true);
                context.SetSkill(arg1: new[] {392}, arg2: true);
                context.SetSkill(arg1: new[] {393}, arg2: true);
                context.SetSkill(arg1: new[] {394}, arg2: true);
                context.SetSkill(arg1: new[] {395}, arg2: true);
                context.SetSkill(arg1: new[] {396}, arg2: true);
                context.SetSkill(arg1: new[] {397}, arg2: true);
                context.SetSkill(arg1: new[] {398}, arg2: true);
                context.SetSkill(arg1: new[] {399}, arg2: true);
                context.SetSkill(arg1: new[] {400}, arg2: true);
                context.SetSkill(arg1: new[] {401}, arg2: true);
                context.SetSkill(arg1: new[] {402}, arg2: true);
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
                context.SetSkill(arg1: new[] {383}, arg2: false);
                context.SetSkill(arg1: new[] {384}, arg2: false);
                context.SetSkill(arg1: new[] {385}, arg2: false);
                context.SetSkill(arg1: new[] {386}, arg2: false);
                context.SetSkill(arg1: new[] {387}, arg2: false);
                context.SetSkill(arg1: new[] {388}, arg2: false);
                context.SetSkill(arg1: new[] {389}, arg2: false);
                context.SetSkill(arg1: new[] {390}, arg2: false);
                context.SetSkill(arg1: new[] {391}, arg2: false);
                context.SetSkill(arg1: new[] {392}, arg2: false);
                context.SetSkill(arg1: new[] {393}, arg2: false);
                context.SetSkill(arg1: new[] {394}, arg2: false);
                context.SetSkill(arg1: new[] {395}, arg2: false);
                context.SetSkill(arg1: new[] {396}, arg2: false);
                context.SetSkill(arg1: new[] {397}, arg2: false);
                context.SetSkill(arg1: new[] {398}, arg2: false);
                context.SetSkill(arg1: new[] {399}, arg2: false);
                context.SetSkill(arg1: new[] {400}, arg2: false);
                context.SetSkill(arg1: new[] {401}, arg2: false);
                context.SetSkill(arg1: new[] {402}, arg2: false);
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
                context.SetSkill(arg1: new[] {389}, arg2: true);
                context.SetSkill(arg1: new[] {390}, arg2: true);
                context.SetSkill(arg1: new[] {391}, arg2: true);
                context.SetSkill(arg1: new[] {392}, arg2: true);
                context.SetSkill(arg1: new[] {393}, arg2: true);
                context.SetSkill(arg1: new[] {394}, arg2: true);
                context.SetSkill(arg1: new[] {395}, arg2: true);
                context.SetSkill(arg1: new[] {396}, arg2: true);
                context.SetSkill(arg1: new[] {397}, arg2: true);
                context.SetSkill(arg1: new[] {398}, arg2: true);
                context.SetSkill(arg1: new[] {399}, arg2: true);
                context.SetSkill(arg1: new[] {400}, arg2: true);
                context.SetSkill(arg1: new[] {401}, arg2: true);
                context.SetSkill(arg1: new[] {402}, arg2: true);
                context.SetSkill(arg1: new[] {403}, arg2: true);
                context.SetSkill(arg1: new[] {404}, arg2: true);
                context.SetSkill(arg1: new[] {405}, arg2: true);
                context.SetSkill(arg1: new[] {406}, arg2: true);
                context.SetSkill(arg1: new[] {407}, arg2: true);
                context.SetSkill(arg1: new[] {408}, arg2: true);
                context.SetSkill(arg1: new[] {409}, arg2: true);
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
                context.SetSkill(arg1: new[] {389}, arg2: false);
                context.SetSkill(arg1: new[] {390}, arg2: false);
                context.SetSkill(arg1: new[] {391}, arg2: false);
                context.SetSkill(arg1: new[] {392}, arg2: false);
                context.SetSkill(arg1: new[] {393}, arg2: false);
                context.SetSkill(arg1: new[] {394}, arg2: false);
                context.SetSkill(arg1: new[] {395}, arg2: false);
                context.SetSkill(arg1: new[] {396}, arg2: false);
                context.SetSkill(arg1: new[] {397}, arg2: false);
                context.SetSkill(arg1: new[] {398}, arg2: false);
                context.SetSkill(arg1: new[] {399}, arg2: false);
                context.SetSkill(arg1: new[] {400}, arg2: false);
                context.SetSkill(arg1: new[] {401}, arg2: false);
                context.SetSkill(arg1: new[] {402}, arg2: false);
                context.SetSkill(arg1: new[] {403}, arg2: false);
                context.SetSkill(arg1: new[] {404}, arg2: false);
                context.SetSkill(arg1: new[] {405}, arg2: false);
                context.SetSkill(arg1: new[] {406}, arg2: false);
                context.SetSkill(arg1: new[] {407}, arg2: false);
                context.SetSkill(arg1: new[] {408}, arg2: false);
                context.SetSkill(arg1: new[] {409}, arg2: false);
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
                context.SetSkill(arg1: new[] {396}, arg2: true);
                context.SetSkill(arg1: new[] {397}, arg2: true);
                context.SetSkill(arg1: new[] {398}, arg2: true);
                context.SetSkill(arg1: new[] {399}, arg2: true);
                context.SetSkill(arg1: new[] {400}, arg2: true);
                context.SetSkill(arg1: new[] {401}, arg2: true);
                context.SetSkill(arg1: new[] {402}, arg2: true);
                context.SetSkill(arg1: new[] {403}, arg2: true);
                context.SetSkill(arg1: new[] {404}, arg2: true);
                context.SetSkill(arg1: new[] {405}, arg2: true);
                context.SetSkill(arg1: new[] {406}, arg2: true);
                context.SetSkill(arg1: new[] {407}, arg2: true);
                context.SetSkill(arg1: new[] {408}, arg2: true);
                context.SetSkill(arg1: new[] {409}, arg2: true);
                context.SetSkill(arg1: new[] {410}, arg2: true);
                context.SetSkill(arg1: new[] {411}, arg2: true);
                context.SetSkill(arg1: new[] {412}, arg2: true);
                context.SetSkill(arg1: new[] {413}, arg2: true);
                context.SetSkill(arg1: new[] {414}, arg2: true);
                context.SetSkill(arg1: new[] {415}, arg2: true);
                context.SetSkill(arg1: new[] {416}, arg2: true);
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
                context.SetSkill(arg1: new[] {396}, arg2: false);
                context.SetSkill(arg1: new[] {397}, arg2: false);
                context.SetSkill(arg1: new[] {398}, arg2: false);
                context.SetSkill(arg1: new[] {399}, arg2: false);
                context.SetSkill(arg1: new[] {400}, arg2: false);
                context.SetSkill(arg1: new[] {401}, arg2: false);
                context.SetSkill(arg1: new[] {402}, arg2: false);
                context.SetSkill(arg1: new[] {403}, arg2: false);
                context.SetSkill(arg1: new[] {404}, arg2: false);
                context.SetSkill(arg1: new[] {405}, arg2: false);
                context.SetSkill(arg1: new[] {406}, arg2: false);
                context.SetSkill(arg1: new[] {407}, arg2: false);
                context.SetSkill(arg1: new[] {408}, arg2: false);
                context.SetSkill(arg1: new[] {409}, arg2: false);
                context.SetSkill(arg1: new[] {410}, arg2: false);
                context.SetSkill(arg1: new[] {411}, arg2: false);
                context.SetSkill(arg1: new[] {412}, arg2: false);
                context.SetSkill(arg1: new[] {413}, arg2: false);
                context.SetSkill(arg1: new[] {414}, arg2: false);
                context.SetSkill(arg1: new[] {415}, arg2: false);
                context.SetSkill(arg1: new[] {416}, arg2: false);
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
                context.SetSkill(arg1: new[] {403}, arg2: true);
                context.SetSkill(arg1: new[] {404}, arg2: true);
                context.SetSkill(arg1: new[] {405}, arg2: true);
                context.SetSkill(arg1: new[] {406}, arg2: true);
                context.SetSkill(arg1: new[] {407}, arg2: true);
                context.SetSkill(arg1: new[] {408}, arg2: true);
                context.SetSkill(arg1: new[] {409}, arg2: true);
                context.SetSkill(arg1: new[] {410}, arg2: true);
                context.SetSkill(arg1: new[] {411}, arg2: true);
                context.SetSkill(arg1: new[] {412}, arg2: true);
                context.SetSkill(arg1: new[] {413}, arg2: true);
                context.SetSkill(arg1: new[] {414}, arg2: true);
                context.SetSkill(arg1: new[] {415}, arg2: true);
                context.SetSkill(arg1: new[] {416}, arg2: true);
                context.SetSkill(arg1: new[] {417}, arg2: true);
                context.SetSkill(arg1: new[] {418}, arg2: true);
                context.SetSkill(arg1: new[] {419}, arg2: true);
                context.SetSkill(arg1: new[] {420}, arg2: true);
                context.SetSkill(arg1: new[] {421}, arg2: true);
                context.SetSkill(arg1: new[] {422}, arg2: true);
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
                context.SetSkill(arg1: new[] {403}, arg2: false);
                context.SetSkill(arg1: new[] {404}, arg2: false);
                context.SetSkill(arg1: new[] {405}, arg2: false);
                context.SetSkill(arg1: new[] {406}, arg2: false);
                context.SetSkill(arg1: new[] {407}, arg2: false);
                context.SetSkill(arg1: new[] {408}, arg2: false);
                context.SetSkill(arg1: new[] {409}, arg2: false);
                context.SetSkill(arg1: new[] {410}, arg2: false);
                context.SetSkill(arg1: new[] {411}, arg2: false);
                context.SetSkill(arg1: new[] {412}, arg2: false);
                context.SetSkill(arg1: new[] {413}, arg2: false);
                context.SetSkill(arg1: new[] {414}, arg2: false);
                context.SetSkill(arg1: new[] {415}, arg2: false);
                context.SetSkill(arg1: new[] {416}, arg2: false);
                context.SetSkill(arg1: new[] {417}, arg2: false);
                context.SetSkill(arg1: new[] {418}, arg2: false);
                context.SetSkill(arg1: new[] {419}, arg2: false);
                context.SetSkill(arg1: new[] {420}, arg2: false);
                context.SetSkill(arg1: new[] {421}, arg2: false);
                context.SetSkill(arg1: new[] {422}, arg2: false);
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
                context.SetSkill(arg1: new[] {410}, arg2: true);
                context.SetSkill(arg1: new[] {411}, arg2: true);
                context.SetSkill(arg1: new[] {412}, arg2: true);
                context.SetSkill(arg1: new[] {413}, arg2: true);
                context.SetSkill(arg1: new[] {414}, arg2: true);
                context.SetSkill(arg1: new[] {415}, arg2: true);
                context.SetSkill(arg1: new[] {416}, arg2: true);
                context.SetSkill(arg1: new[] {417}, arg2: true);
                context.SetSkill(arg1: new[] {418}, arg2: true);
                context.SetSkill(arg1: new[] {419}, arg2: true);
                context.SetSkill(arg1: new[] {420}, arg2: true);
                context.SetSkill(arg1: new[] {421}, arg2: true);
                context.SetSkill(arg1: new[] {422}, arg2: true);
                context.SetSkill(arg1: new[] {423}, arg2: true);
                context.SetSkill(arg1: new[] {424}, arg2: true);
                context.SetSkill(arg1: new[] {425}, arg2: true);
                context.SetSkill(arg1: new[] {426}, arg2: true);
                context.SetSkill(arg1: new[] {427}, arg2: true);
                context.SetSkill(arg1: new[] {428}, arg2: true);
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
                context.SetSkill(arg1: new[] {410}, arg2: false);
                context.SetSkill(arg1: new[] {411}, arg2: false);
                context.SetSkill(arg1: new[] {412}, arg2: false);
                context.SetSkill(arg1: new[] {413}, arg2: false);
                context.SetSkill(arg1: new[] {414}, arg2: false);
                context.SetSkill(arg1: new[] {415}, arg2: false);
                context.SetSkill(arg1: new[] {416}, arg2: false);
                context.SetSkill(arg1: new[] {417}, arg2: false);
                context.SetSkill(arg1: new[] {418}, arg2: false);
                context.SetSkill(arg1: new[] {419}, arg2: false);
                context.SetSkill(arg1: new[] {420}, arg2: false);
                context.SetSkill(arg1: new[] {421}, arg2: false);
                context.SetSkill(arg1: new[] {422}, arg2: false);
                context.SetSkill(arg1: new[] {423}, arg2: false);
                context.SetSkill(arg1: new[] {424}, arg2: false);
                context.SetSkill(arg1: new[] {425}, arg2: false);
                context.SetSkill(arg1: new[] {426}, arg2: false);
                context.SetSkill(arg1: new[] {427}, arg2: false);
                context.SetSkill(arg1: new[] {428}, arg2: false);
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
                context.SetSkill(arg1: new[] {417}, arg2: true);
                context.SetSkill(arg1: new[] {418}, arg2: true);
                context.SetSkill(arg1: new[] {419}, arg2: true);
                context.SetSkill(arg1: new[] {420}, arg2: true);
                context.SetSkill(arg1: new[] {421}, arg2: true);
                context.SetSkill(arg1: new[] {422}, arg2: true);
                context.SetSkill(arg1: new[] {423}, arg2: true);
                context.SetSkill(arg1: new[] {424}, arg2: true);
                context.SetSkill(arg1: new[] {425}, arg2: true);
                context.SetSkill(arg1: new[] {426}, arg2: true);
                context.SetSkill(arg1: new[] {427}, arg2: true);
                context.SetSkill(arg1: new[] {428}, arg2: true);
                context.SetSkill(arg1: new[] {429}, arg2: true);
                context.SetSkill(arg1: new[] {430}, arg2: true);
                context.SetSkill(arg1: new[] {431}, arg2: true);
                context.SetSkill(arg1: new[] {432}, arg2: true);
                context.SetSkill(arg1: new[] {433}, arg2: true);
                context.SetSkill(arg1: new[] {434}, arg2: true);
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
                context.SetSkill(arg1: new[] {417}, arg2: false);
                context.SetSkill(arg1: new[] {418}, arg2: false);
                context.SetSkill(arg1: new[] {419}, arg2: false);
                context.SetSkill(arg1: new[] {420}, arg2: false);
                context.SetSkill(arg1: new[] {421}, arg2: false);
                context.SetSkill(arg1: new[] {422}, arg2: false);
                context.SetSkill(arg1: new[] {423}, arg2: false);
                context.SetSkill(arg1: new[] {424}, arg2: false);
                context.SetSkill(arg1: new[] {425}, arg2: false);
                context.SetSkill(arg1: new[] {426}, arg2: false);
                context.SetSkill(arg1: new[] {427}, arg2: false);
                context.SetSkill(arg1: new[] {428}, arg2: false);
                context.SetSkill(arg1: new[] {429}, arg2: false);
                context.SetSkill(arg1: new[] {430}, arg2: false);
                context.SetSkill(arg1: new[] {431}, arg2: false);
                context.SetSkill(arg1: new[] {432}, arg2: false);
                context.SetSkill(arg1: new[] {433}, arg2: false);
                context.SetSkill(arg1: new[] {434}, arg2: false);
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
                context.SetSkill(arg1: new[] {423}, arg2: true);
                context.SetSkill(arg1: new[] {424}, arg2: true);
                context.SetSkill(arg1: new[] {425}, arg2: true);
                context.SetSkill(arg1: new[] {426}, arg2: true);
                context.SetSkill(arg1: new[] {427}, arg2: true);
                context.SetSkill(arg1: new[] {428}, arg2: true);
                context.SetSkill(arg1: new[] {429}, arg2: true);
                context.SetSkill(arg1: new[] {430}, arg2: true);
                context.SetSkill(arg1: new[] {431}, arg2: true);
                context.SetSkill(arg1: new[] {432}, arg2: true);
                context.SetSkill(arg1: new[] {433}, arg2: true);
                context.SetSkill(arg1: new[] {434}, arg2: true);
                context.SetSkill(arg1: new[] {435}, arg2: true);
                context.SetSkill(arg1: new[] {436}, arg2: true);
                context.SetSkill(arg1: new[] {437}, arg2: true);
                context.SetSkill(arg1: new[] {438}, arg2: true);
                context.SetSkill(arg1: new[] {439}, arg2: true);
                context.SetSkill(arg1: new[] {440}, arg2: true);
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
                context.SetSkill(arg1: new[] {423}, arg2: false);
                context.SetSkill(arg1: new[] {424}, arg2: false);
                context.SetSkill(arg1: new[] {425}, arg2: false);
                context.SetSkill(arg1: new[] {426}, arg2: false);
                context.SetSkill(arg1: new[] {427}, arg2: false);
                context.SetSkill(arg1: new[] {428}, arg2: false);
                context.SetSkill(arg1: new[] {429}, arg2: false);
                context.SetSkill(arg1: new[] {430}, arg2: false);
                context.SetSkill(arg1: new[] {431}, arg2: false);
                context.SetSkill(arg1: new[] {432}, arg2: false);
                context.SetSkill(arg1: new[] {433}, arg2: false);
                context.SetSkill(arg1: new[] {434}, arg2: false);
                context.SetSkill(arg1: new[] {435}, arg2: false);
                context.SetSkill(arg1: new[] {436}, arg2: false);
                context.SetSkill(arg1: new[] {437}, arg2: false);
                context.SetSkill(arg1: new[] {438}, arg2: false);
                context.SetSkill(arg1: new[] {439}, arg2: false);
                context.SetSkill(arg1: new[] {440}, arg2: false);
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
                context.SetSkill(arg1: new[] {429}, arg2: true);
                context.SetSkill(arg1: new[] {430}, arg2: true);
                context.SetSkill(arg1: new[] {431}, arg2: true);
                context.SetSkill(arg1: new[] {432}, arg2: true);
                context.SetSkill(arg1: new[] {433}, arg2: true);
                context.SetSkill(arg1: new[] {434}, arg2: true);
                context.SetSkill(arg1: new[] {435}, arg2: true);
                context.SetSkill(arg1: new[] {436}, arg2: true);
                context.SetSkill(arg1: new[] {437}, arg2: true);
                context.SetSkill(arg1: new[] {438}, arg2: true);
                context.SetSkill(arg1: new[] {439}, arg2: true);
                context.SetSkill(arg1: new[] {440}, arg2: true);
                context.SetSkill(arg1: new[] {441}, arg2: true);
                context.SetSkill(arg1: new[] {442}, arg2: true);
                context.SetSkill(arg1: new[] {443}, arg2: true);
                context.SetSkill(arg1: new[] {444}, arg2: true);
                context.SetSkill(arg1: new[] {445}, arg2: true);
                context.SetSkill(arg1: new[] {446}, arg2: true);
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
                context.SetSkill(arg1: new[] {429}, arg2: false);
                context.SetSkill(arg1: new[] {430}, arg2: false);
                context.SetSkill(arg1: new[] {431}, arg2: false);
                context.SetSkill(arg1: new[] {432}, arg2: false);
                context.SetSkill(arg1: new[] {433}, arg2: false);
                context.SetSkill(arg1: new[] {434}, arg2: false);
                context.SetSkill(arg1: new[] {435}, arg2: false);
                context.SetSkill(arg1: new[] {436}, arg2: false);
                context.SetSkill(arg1: new[] {437}, arg2: false);
                context.SetSkill(arg1: new[] {438}, arg2: false);
                context.SetSkill(arg1: new[] {439}, arg2: false);
                context.SetSkill(arg1: new[] {440}, arg2: false);
                context.SetSkill(arg1: new[] {441}, arg2: false);
                context.SetSkill(arg1: new[] {442}, arg2: false);
                context.SetSkill(arg1: new[] {443}, arg2: false);
                context.SetSkill(arg1: new[] {444}, arg2: false);
                context.SetSkill(arg1: new[] {445}, arg2: false);
                context.SetSkill(arg1: new[] {446}, arg2: false);
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
                context.SetSkill(arg1: new[] {435}, arg2: true);
                context.SetSkill(arg1: new[] {436}, arg2: true);
                context.SetSkill(arg1: new[] {437}, arg2: true);
                context.SetSkill(arg1: new[] {438}, arg2: true);
                context.SetSkill(arg1: new[] {439}, arg2: true);
                context.SetSkill(arg1: new[] {440}, arg2: true);
                context.SetSkill(arg1: new[] {441}, arg2: true);
                context.SetSkill(arg1: new[] {442}, arg2: true);
                context.SetSkill(arg1: new[] {443}, arg2: true);
                context.SetSkill(arg1: new[] {444}, arg2: true);
                context.SetSkill(arg1: new[] {445}, arg2: true);
                context.SetSkill(arg1: new[] {446}, arg2: true);
                context.SetSkill(arg1: new[] {447}, arg2: true);
                context.SetSkill(arg1: new[] {448}, arg2: true);
                context.SetSkill(arg1: new[] {449}, arg2: true);
                context.SetSkill(arg1: new[] {450}, arg2: true);
                context.SetSkill(arg1: new[] {451}, arg2: true);
                context.SetSkill(arg1: new[] {452}, arg2: true);
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
                context.SetSkill(arg1: new[] {435}, arg2: false);
                context.SetSkill(arg1: new[] {436}, arg2: false);
                context.SetSkill(arg1: new[] {437}, arg2: false);
                context.SetSkill(arg1: new[] {438}, arg2: false);
                context.SetSkill(arg1: new[] {439}, arg2: false);
                context.SetSkill(arg1: new[] {440}, arg2: false);
                context.SetSkill(arg1: new[] {441}, arg2: false);
                context.SetSkill(arg1: new[] {442}, arg2: false);
                context.SetSkill(arg1: new[] {443}, arg2: false);
                context.SetSkill(arg1: new[] {444}, arg2: false);
                context.SetSkill(arg1: new[] {445}, arg2: false);
                context.SetSkill(arg1: new[] {446}, arg2: false);
                context.SetSkill(arg1: new[] {447}, arg2: false);
                context.SetSkill(arg1: new[] {448}, arg2: false);
                context.SetSkill(arg1: new[] {449}, arg2: false);
                context.SetSkill(arg1: new[] {450}, arg2: false);
                context.SetSkill(arg1: new[] {451}, arg2: false);
                context.SetSkill(arg1: new[] {452}, arg2: false);
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
                context.SetSkill(arg1: new[] {441}, arg2: true);
                context.SetSkill(arg1: new[] {442}, arg2: true);
                context.SetSkill(arg1: new[] {443}, arg2: true);
                context.SetSkill(arg1: new[] {444}, arg2: true);
                context.SetSkill(arg1: new[] {445}, arg2: true);
                context.SetSkill(arg1: new[] {446}, arg2: true);
                context.SetSkill(arg1: new[] {447}, arg2: true);
                context.SetSkill(arg1: new[] {448}, arg2: true);
                context.SetSkill(arg1: new[] {449}, arg2: true);
                context.SetSkill(arg1: new[] {450}, arg2: true);
                context.SetSkill(arg1: new[] {451}, arg2: true);
                context.SetSkill(arg1: new[] {452}, arg2: true);
                context.SetSkill(arg1: new[] {453}, arg2: true);
                context.SetSkill(arg1: new[] {454}, arg2: true);
                context.SetSkill(arg1: new[] {455}, arg2: true);
                context.SetSkill(arg1: new[] {456}, arg2: true);
                context.SetSkill(arg1: new[] {457}, arg2: true);
                context.SetSkill(arg1: new[] {458}, arg2: true);
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
                context.SetSkill(arg1: new[] {441}, arg2: false);
                context.SetSkill(arg1: new[] {442}, arg2: false);
                context.SetSkill(arg1: new[] {443}, arg2: false);
                context.SetSkill(arg1: new[] {444}, arg2: false);
                context.SetSkill(arg1: new[] {445}, arg2: false);
                context.SetSkill(arg1: new[] {446}, arg2: false);
                context.SetSkill(arg1: new[] {447}, arg2: false);
                context.SetSkill(arg1: new[] {448}, arg2: false);
                context.SetSkill(arg1: new[] {449}, arg2: false);
                context.SetSkill(arg1: new[] {450}, arg2: false);
                context.SetSkill(arg1: new[] {451}, arg2: false);
                context.SetSkill(arg1: new[] {452}, arg2: false);
                context.SetSkill(arg1: new[] {453}, arg2: false);
                context.SetSkill(arg1: new[] {454}, arg2: false);
                context.SetSkill(arg1: new[] {455}, arg2: false);
                context.SetSkill(arg1: new[] {456}, arg2: false);
                context.SetSkill(arg1: new[] {457}, arg2: false);
                context.SetSkill(arg1: new[] {458}, arg2: false);
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
                context.SetSkill(arg1: new[] {447}, arg2: true);
                context.SetSkill(arg1: new[] {448}, arg2: true);
                context.SetSkill(arg1: new[] {449}, arg2: true);
                context.SetSkill(arg1: new[] {450}, arg2: true);
                context.SetSkill(arg1: new[] {451}, arg2: true);
                context.SetSkill(arg1: new[] {452}, arg2: true);
                context.SetSkill(arg1: new[] {453}, arg2: true);
                context.SetSkill(arg1: new[] {454}, arg2: true);
                context.SetSkill(arg1: new[] {455}, arg2: true);
                context.SetSkill(arg1: new[] {456}, arg2: true);
                context.SetSkill(arg1: new[] {457}, arg2: true);
                context.SetSkill(arg1: new[] {458}, arg2: true);
                context.SetSkill(arg1: new[] {459}, arg2: true);
                context.SetSkill(arg1: new[] {460}, arg2: true);
                context.SetSkill(arg1: new[] {461}, arg2: true);
                context.SetSkill(arg1: new[] {462}, arg2: true);
                context.SetSkill(arg1: new[] {463}, arg2: true);
                context.SetSkill(arg1: new[] {464}, arg2: true);
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
                context.SetSkill(arg1: new[] {447}, arg2: false);
                context.SetSkill(arg1: new[] {448}, arg2: false);
                context.SetSkill(arg1: new[] {449}, arg2: false);
                context.SetSkill(arg1: new[] {450}, arg2: false);
                context.SetSkill(arg1: new[] {451}, arg2: false);
                context.SetSkill(arg1: new[] {452}, arg2: false);
                context.SetSkill(arg1: new[] {453}, arg2: false);
                context.SetSkill(arg1: new[] {454}, arg2: false);
                context.SetSkill(arg1: new[] {455}, arg2: false);
                context.SetSkill(arg1: new[] {456}, arg2: false);
                context.SetSkill(arg1: new[] {457}, arg2: false);
                context.SetSkill(arg1: new[] {458}, arg2: false);
                context.SetSkill(arg1: new[] {459}, arg2: false);
                context.SetSkill(arg1: new[] {460}, arg2: false);
                context.SetSkill(arg1: new[] {461}, arg2: false);
                context.SetSkill(arg1: new[] {462}, arg2: false);
                context.SetSkill(arg1: new[] {463}, arg2: false);
                context.SetSkill(arg1: new[] {464}, arg2: false);
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
                context.SetSkill(arg1: new[] {453}, arg2: true);
                context.SetSkill(arg1: new[] {454}, arg2: true);
                context.SetSkill(arg1: new[] {455}, arg2: true);
                context.SetSkill(arg1: new[] {456}, arg2: true);
                context.SetSkill(arg1: new[] {457}, arg2: true);
                context.SetSkill(arg1: new[] {458}, arg2: true);
                context.SetSkill(arg1: new[] {459}, arg2: true);
                context.SetSkill(arg1: new[] {460}, arg2: true);
                context.SetSkill(arg1: new[] {461}, arg2: true);
                context.SetSkill(arg1: new[] {462}, arg2: true);
                context.SetSkill(arg1: new[] {463}, arg2: true);
                context.SetSkill(arg1: new[] {464}, arg2: true);
                context.SetSkill(arg1: new[] {465}, arg2: true);
                context.SetSkill(arg1: new[] {466}, arg2: true);
                context.SetSkill(arg1: new[] {467}, arg2: true);
                context.SetSkill(arg1: new[] {468}, arg2: true);
                context.SetSkill(arg1: new[] {469}, arg2: true);
                context.SetSkill(arg1: new[] {470}, arg2: true);
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
                context.SetSkill(arg1: new[] {453}, arg2: false);
                context.SetSkill(arg1: new[] {454}, arg2: false);
                context.SetSkill(arg1: new[] {455}, arg2: false);
                context.SetSkill(arg1: new[] {456}, arg2: false);
                context.SetSkill(arg1: new[] {457}, arg2: false);
                context.SetSkill(arg1: new[] {458}, arg2: false);
                context.SetSkill(arg1: new[] {459}, arg2: false);
                context.SetSkill(arg1: new[] {460}, arg2: false);
                context.SetSkill(arg1: new[] {461}, arg2: false);
                context.SetSkill(arg1: new[] {462}, arg2: false);
                context.SetSkill(arg1: new[] {463}, arg2: false);
                context.SetSkill(arg1: new[] {464}, arg2: false);
                context.SetSkill(arg1: new[] {465}, arg2: false);
                context.SetSkill(arg1: new[] {466}, arg2: false);
                context.SetSkill(arg1: new[] {467}, arg2: false);
                context.SetSkill(arg1: new[] {468}, arg2: false);
                context.SetSkill(arg1: new[] {469}, arg2: false);
                context.SetSkill(arg1: new[] {470}, arg2: false);
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
                context.SetSkill(arg1: new[] {459}, arg2: true);
                context.SetSkill(arg1: new[] {460}, arg2: true);
                context.SetSkill(arg1: new[] {461}, arg2: true);
                context.SetSkill(arg1: new[] {462}, arg2: true);
                context.SetSkill(arg1: new[] {463}, arg2: true);
                context.SetSkill(arg1: new[] {464}, arg2: true);
                context.SetSkill(arg1: new[] {465}, arg2: true);
                context.SetSkill(arg1: new[] {466}, arg2: true);
                context.SetSkill(arg1: new[] {467}, arg2: true);
                context.SetSkill(arg1: new[] {468}, arg2: true);
                context.SetSkill(arg1: new[] {469}, arg2: true);
                context.SetSkill(arg1: new[] {470}, arg2: true);
                context.SetSkill(arg1: new[] {471}, arg2: true);
                context.SetSkill(arg1: new[] {472}, arg2: true);
                context.SetSkill(arg1: new[] {473}, arg2: true);
                context.SetSkill(arg1: new[] {474}, arg2: true);
                context.SetSkill(arg1: new[] {475}, arg2: true);
                context.SetSkill(arg1: new[] {476}, arg2: true);
                context.SetSkill(arg1: new[] {477}, arg2: true);
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
                context.SetSkill(arg1: new[] {459}, arg2: false);
                context.SetSkill(arg1: new[] {460}, arg2: false);
                context.SetSkill(arg1: new[] {461}, arg2: false);
                context.SetSkill(arg1: new[] {462}, arg2: false);
                context.SetSkill(arg1: new[] {463}, arg2: false);
                context.SetSkill(arg1: new[] {464}, arg2: false);
                context.SetSkill(arg1: new[] {465}, arg2: false);
                context.SetSkill(arg1: new[] {466}, arg2: false);
                context.SetSkill(arg1: new[] {467}, arg2: false);
                context.SetSkill(arg1: new[] {468}, arg2: false);
                context.SetSkill(arg1: new[] {469}, arg2: false);
                context.SetSkill(arg1: new[] {470}, arg2: false);
                context.SetSkill(arg1: new[] {471}, arg2: false);
                context.SetSkill(arg1: new[] {472}, arg2: false);
                context.SetSkill(arg1: new[] {473}, arg2: false);
                context.SetSkill(arg1: new[] {474}, arg2: false);
                context.SetSkill(arg1: new[] {475}, arg2: false);
                context.SetSkill(arg1: new[] {476}, arg2: false);
                context.SetSkill(arg1: new[] {477}, arg2: false);
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
                context.SetSkill(arg1: new[] {465}, arg2: true);
                context.SetSkill(arg1: new[] {466}, arg2: true);
                context.SetSkill(arg1: new[] {467}, arg2: true);
                context.SetSkill(arg1: new[] {468}, arg2: true);
                context.SetSkill(arg1: new[] {469}, arg2: true);
                context.SetSkill(arg1: new[] {470}, arg2: true);
                context.SetSkill(arg1: new[] {471}, arg2: true);
                context.SetSkill(arg1: new[] {472}, arg2: true);
                context.SetSkill(arg1: new[] {473}, arg2: true);
                context.SetSkill(arg1: new[] {474}, arg2: true);
                context.SetSkill(arg1: new[] {475}, arg2: true);
                context.SetSkill(arg1: new[] {476}, arg2: true);
                context.SetSkill(arg1: new[] {477}, arg2: true);
                context.SetSkill(arg1: new[] {478}, arg2: true);
                context.SetSkill(arg1: new[] {479}, arg2: true);
                context.SetSkill(arg1: new[] {480}, arg2: true);
                context.SetSkill(arg1: new[] {481}, arg2: true);
                context.SetSkill(arg1: new[] {482}, arg2: true);
                context.SetSkill(arg1: new[] {483}, arg2: true);
                context.SetSkill(arg1: new[] {484}, arg2: true);
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
                context.SetSkill(arg1: new[] {465}, arg2: false);
                context.SetSkill(arg1: new[] {466}, arg2: false);
                context.SetSkill(arg1: new[] {467}, arg2: false);
                context.SetSkill(arg1: new[] {468}, arg2: false);
                context.SetSkill(arg1: new[] {469}, arg2: false);
                context.SetSkill(arg1: new[] {470}, arg2: false);
                context.SetSkill(arg1: new[] {471}, arg2: false);
                context.SetSkill(arg1: new[] {472}, arg2: false);
                context.SetSkill(arg1: new[] {473}, arg2: false);
                context.SetSkill(arg1: new[] {474}, arg2: false);
                context.SetSkill(arg1: new[] {475}, arg2: false);
                context.SetSkill(arg1: new[] {476}, arg2: false);
                context.SetSkill(arg1: new[] {477}, arg2: false);
                context.SetSkill(arg1: new[] {478}, arg2: false);
                context.SetSkill(arg1: new[] {479}, arg2: false);
                context.SetSkill(arg1: new[] {480}, arg2: false);
                context.SetSkill(arg1: new[] {481}, arg2: false);
                context.SetSkill(arg1: new[] {482}, arg2: false);
                context.SetSkill(arg1: new[] {483}, arg2: false);
                context.SetSkill(arg1: new[] {484}, arg2: false);
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
                context.SetSkill(arg1: new[] {471}, arg2: true);
                context.SetSkill(arg1: new[] {472}, arg2: true);
                context.SetSkill(arg1: new[] {473}, arg2: true);
                context.SetSkill(arg1: new[] {474}, arg2: true);
                context.SetSkill(arg1: new[] {475}, arg2: true);
                context.SetSkill(arg1: new[] {476}, arg2: true);
                context.SetSkill(arg1: new[] {477}, arg2: true);
                context.SetSkill(arg1: new[] {478}, arg2: true);
                context.SetSkill(arg1: new[] {479}, arg2: true);
                context.SetSkill(arg1: new[] {480}, arg2: true);
                context.SetSkill(arg1: new[] {481}, arg2: true);
                context.SetSkill(arg1: new[] {482}, arg2: true);
                context.SetSkill(arg1: new[] {483}, arg2: true);
                context.SetSkill(arg1: new[] {484}, arg2: true);
                context.SetSkill(arg1: new[] {485}, arg2: true);
                context.SetSkill(arg1: new[] {486}, arg2: true);
                context.SetSkill(arg1: new[] {487}, arg2: true);
                context.SetSkill(arg1: new[] {488}, arg2: true);
                context.SetSkill(arg1: new[] {489}, arg2: true);
                context.SetSkill(arg1: new[] {490}, arg2: true);
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
                context.SetSkill(arg1: new[] {471}, arg2: false);
                context.SetSkill(arg1: new[] {472}, arg2: false);
                context.SetSkill(arg1: new[] {473}, arg2: false);
                context.SetSkill(arg1: new[] {474}, arg2: false);
                context.SetSkill(arg1: new[] {475}, arg2: false);
                context.SetSkill(arg1: new[] {476}, arg2: false);
                context.SetSkill(arg1: new[] {477}, arg2: false);
                context.SetSkill(arg1: new[] {478}, arg2: false);
                context.SetSkill(arg1: new[] {479}, arg2: false);
                context.SetSkill(arg1: new[] {480}, arg2: false);
                context.SetSkill(arg1: new[] {481}, arg2: false);
                context.SetSkill(arg1: new[] {482}, arg2: false);
                context.SetSkill(arg1: new[] {483}, arg2: false);
                context.SetSkill(arg1: new[] {484}, arg2: false);
                context.SetSkill(arg1: new[] {485}, arg2: false);
                context.SetSkill(arg1: new[] {486}, arg2: false);
                context.SetSkill(arg1: new[] {487}, arg2: false);
                context.SetSkill(arg1: new[] {488}, arg2: false);
                context.SetSkill(arg1: new[] {489}, arg2: false);
                context.SetSkill(arg1: new[] {490}, arg2: false);
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
                context.SetSkill(arg1: new[] {478}, arg2: true);
                context.SetSkill(arg1: new[] {479}, arg2: true);
                context.SetSkill(arg1: new[] {480}, arg2: true);
                context.SetSkill(arg1: new[] {481}, arg2: true);
                context.SetSkill(arg1: new[] {482}, arg2: true);
                context.SetSkill(arg1: new[] {483}, arg2: true);
                context.SetSkill(arg1: new[] {484}, arg2: true);
                context.SetSkill(arg1: new[] {485}, arg2: true);
                context.SetSkill(arg1: new[] {486}, arg2: true);
                context.SetSkill(arg1: new[] {487}, arg2: true);
                context.SetSkill(arg1: new[] {488}, arg2: true);
                context.SetSkill(arg1: new[] {489}, arg2: true);
                context.SetSkill(arg1: new[] {490}, arg2: true);
                context.SetSkill(arg1: new[] {491}, arg2: true);
                context.SetSkill(arg1: new[] {492}, arg2: true);
                context.SetSkill(arg1: new[] {493}, arg2: true);
                context.SetSkill(arg1: new[] {494}, arg2: true);
                context.SetSkill(arg1: new[] {495}, arg2: true);
                context.SetSkill(arg1: new[] {496}, arg2: true);
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
                context.SetSkill(arg1: new[] {478}, arg2: false);
                context.SetSkill(arg1: new[] {479}, arg2: false);
                context.SetSkill(arg1: new[] {480}, arg2: false);
                context.SetSkill(arg1: new[] {481}, arg2: false);
                context.SetSkill(arg1: new[] {482}, arg2: false);
                context.SetSkill(arg1: new[] {483}, arg2: false);
                context.SetSkill(arg1: new[] {484}, arg2: false);
                context.SetSkill(arg1: new[] {485}, arg2: false);
                context.SetSkill(arg1: new[] {486}, arg2: false);
                context.SetSkill(arg1: new[] {487}, arg2: false);
                context.SetSkill(arg1: new[] {488}, arg2: false);
                context.SetSkill(arg1: new[] {489}, arg2: false);
                context.SetSkill(arg1: new[] {490}, arg2: false);
                context.SetSkill(arg1: new[] {491}, arg2: false);
                context.SetSkill(arg1: new[] {492}, arg2: false);
                context.SetSkill(arg1: new[] {493}, arg2: false);
                context.SetSkill(arg1: new[] {494}, arg2: false);
                context.SetSkill(arg1: new[] {495}, arg2: false);
                context.SetSkill(arg1: new[] {496}, arg2: false);
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
                context.SetSkill(arg1: new[] {485}, arg2: true);
                context.SetSkill(arg1: new[] {486}, arg2: true);
                context.SetSkill(arg1: new[] {487}, arg2: true);
                context.SetSkill(arg1: new[] {488}, arg2: true);
                context.SetSkill(arg1: new[] {489}, arg2: true);
                context.SetSkill(arg1: new[] {490}, arg2: true);
                context.SetSkill(arg1: new[] {491}, arg2: true);
                context.SetSkill(arg1: new[] {492}, arg2: true);
                context.SetSkill(arg1: new[] {493}, arg2: true);
                context.SetSkill(arg1: new[] {494}, arg2: true);
                context.SetSkill(arg1: new[] {495}, arg2: true);
                context.SetSkill(arg1: new[] {496}, arg2: true);
                context.SetSkill(arg1: new[] {497}, arg2: true);
                context.SetSkill(arg1: new[] {498}, arg2: true);
                context.SetSkill(arg1: new[] {499}, arg2: true);
                context.SetSkill(arg1: new[] {500}, arg2: true);
                context.SetSkill(arg1: new[] {501}, arg2: true);
                context.SetSkill(arg1: new[] {502}, arg2: true);
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
                context.SetSkill(arg1: new[] {485}, arg2: false);
                context.SetSkill(arg1: new[] {486}, arg2: false);
                context.SetSkill(arg1: new[] {487}, arg2: false);
                context.SetSkill(arg1: new[] {488}, arg2: false);
                context.SetSkill(arg1: new[] {489}, arg2: false);
                context.SetSkill(arg1: new[] {490}, arg2: false);
                context.SetSkill(arg1: new[] {491}, arg2: false);
                context.SetSkill(arg1: new[] {492}, arg2: false);
                context.SetSkill(arg1: new[] {493}, arg2: false);
                context.SetSkill(arg1: new[] {494}, arg2: false);
                context.SetSkill(arg1: new[] {495}, arg2: false);
                context.SetSkill(arg1: new[] {496}, arg2: false);
                context.SetSkill(arg1: new[] {497}, arg2: false);
                context.SetSkill(arg1: new[] {498}, arg2: false);
                context.SetSkill(arg1: new[] {499}, arg2: false);
                context.SetSkill(arg1: new[] {500}, arg2: false);
                context.SetSkill(arg1: new[] {501}, arg2: false);
                context.SetSkill(arg1: new[] {502}, arg2: false);
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
                context.SetSkill(arg1: new[] {491}, arg2: true);
                context.SetSkill(arg1: new[] {492}, arg2: true);
                context.SetSkill(arg1: new[] {493}, arg2: true);
                context.SetSkill(arg1: new[] {494}, arg2: true);
                context.SetSkill(arg1: new[] {495}, arg2: true);
                context.SetSkill(arg1: new[] {496}, arg2: true);
                context.SetSkill(arg1: new[] {497}, arg2: true);
                context.SetSkill(arg1: new[] {498}, arg2: true);
                context.SetSkill(arg1: new[] {499}, arg2: true);
                context.SetSkill(arg1: new[] {500}, arg2: true);
                context.SetSkill(arg1: new[] {501}, arg2: true);
                context.SetSkill(arg1: new[] {502}, arg2: true);
                context.SetSkill(arg1: new[] {503}, arg2: true);
                context.SetSkill(arg1: new[] {504}, arg2: true);
                context.SetSkill(arg1: new[] {505}, arg2: true);
                context.SetSkill(arg1: new[] {506}, arg2: true);
                context.SetSkill(arg1: new[] {507}, arg2: true);
                context.SetSkill(arg1: new[] {508}, arg2: true);
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
                context.SetSkill(arg1: new[] {491}, arg2: false);
                context.SetSkill(arg1: new[] {492}, arg2: false);
                context.SetSkill(arg1: new[] {493}, arg2: false);
                context.SetSkill(arg1: new[] {494}, arg2: false);
                context.SetSkill(arg1: new[] {495}, arg2: false);
                context.SetSkill(arg1: new[] {496}, arg2: false);
                context.SetSkill(arg1: new[] {497}, arg2: false);
                context.SetSkill(arg1: new[] {498}, arg2: false);
                context.SetSkill(arg1: new[] {499}, arg2: false);
                context.SetSkill(arg1: new[] {500}, arg2: false);
                context.SetSkill(arg1: new[] {501}, arg2: false);
                context.SetSkill(arg1: new[] {502}, arg2: false);
                context.SetSkill(arg1: new[] {503}, arg2: false);
                context.SetSkill(arg1: new[] {504}, arg2: false);
                context.SetSkill(arg1: new[] {505}, arg2: false);
                context.SetSkill(arg1: new[] {506}, arg2: false);
                context.SetSkill(arg1: new[] {507}, arg2: false);
                context.SetSkill(arg1: new[] {508}, arg2: false);
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
                context.SetSkill(arg1: new[] {497}, arg2: true);
                context.SetSkill(arg1: new[] {498}, arg2: true);
                context.SetSkill(arg1: new[] {499}, arg2: true);
                context.SetSkill(arg1: new[] {500}, arg2: true);
                context.SetSkill(arg1: new[] {501}, arg2: true);
                context.SetSkill(arg1: new[] {502}, arg2: true);
                context.SetSkill(arg1: new[] {503}, arg2: true);
                context.SetSkill(arg1: new[] {504}, arg2: true);
                context.SetSkill(arg1: new[] {505}, arg2: true);
                context.SetSkill(arg1: new[] {506}, arg2: true);
                context.SetSkill(arg1: new[] {507}, arg2: true);
                context.SetSkill(arg1: new[] {508}, arg2: true);
                context.SetSkill(arg1: new[] {509}, arg2: true);
                context.SetSkill(arg1: new[] {510}, arg2: true);
                context.SetSkill(arg1: new[] {511}, arg2: true);
                context.SetSkill(arg1: new[] {512}, arg2: true);
                context.SetSkill(arg1: new[] {513}, arg2: true);
                context.SetSkill(arg1: new[] {514}, arg2: true);
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
                context.SetSkill(arg1: new[] {497}, arg2: false);
                context.SetSkill(arg1: new[] {498}, arg2: false);
                context.SetSkill(arg1: new[] {499}, arg2: false);
                context.SetSkill(arg1: new[] {500}, arg2: false);
                context.SetSkill(arg1: new[] {501}, arg2: false);
                context.SetSkill(arg1: new[] {502}, arg2: false);
                context.SetSkill(arg1: new[] {503}, arg2: false);
                context.SetSkill(arg1: new[] {504}, arg2: false);
                context.SetSkill(arg1: new[] {505}, arg2: false);
                context.SetSkill(arg1: new[] {506}, arg2: false);
                context.SetSkill(arg1: new[] {507}, arg2: false);
                context.SetSkill(arg1: new[] {508}, arg2: false);
                context.SetSkill(arg1: new[] {509}, arg2: false);
                context.SetSkill(arg1: new[] {510}, arg2: false);
                context.SetSkill(arg1: new[] {511}, arg2: false);
                context.SetSkill(arg1: new[] {512}, arg2: false);
                context.SetSkill(arg1: new[] {513}, arg2: false);
                context.SetSkill(arg1: new[] {514}, arg2: false);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}