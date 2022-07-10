using Maple2.Trigger._dungeon_common;

namespace Maple2.Trigger._02000252_bf {
    public static class _start {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{151, 152, 153, 154, 155, 156}, visible: true);
                context.SetEffect(triggerIds: new []{601, 602, 603, 8001, 8002, 8003, 8004, 8005, 8006, 8007, 8008, 8009, 8010, 8011, 8012}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount() > 0) {
                    return new State로딩Delay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State로딩Delay : TriggerState {
            internal State로딩Delay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new _checkusercount.StateCheckUserCount(context, new StateDungeonStart(context));
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDungeonStart : TriggerState {
            internal StateDungeonStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 20002521);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetTimer(timerId: "1", seconds: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State벨라소환(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematic해제 : TriggerState {
            internal StateCinematic해제(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetTimer(timerId: "1", seconds: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State벨라소환(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State벨라소환 : TriggerState {
            internal State벨라소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelectPath(pathIds: new []{8801, 8802}, returnView: false);
                context.CreateMonster(spawnIds: new []{1001});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State벨라대사(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State벨라대사 : TriggerState {
            internal State벨라대사(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(state: new State벨라스킬Delay(context), arg2: "nextState");
                context.SetSkip(state: new State벨라스킬Delay(context));
                context.SetTimer(timerId: "1", seconds: 6);
                context.SetConversation(type: 2, spawnId: 11000057, script: "$02000252_BF__START__4$", arg4: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State벨라Script2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State벨라Script2 : TriggerState {
            internal State벨라Script2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 8);
                context.SetConversation(type: 2, spawnId: 11000057, script: "$02000252_BF__START__5$", arg4: 4);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State벨라Script3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State벨라Script3 : TriggerState {
            internal State벨라Script3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 4);
                context.SetSceneSkip();
                context.SetConversation(type: 2, spawnId: 11000057, script: "$02000252_BF__START__6$", arg4: 4);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6243)) {
                    return new State벨라스킬Delay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State벨라스킬Delay : TriggerState {
            internal State벨라스킬Delay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 1001, patrolName: "MS2PatrolData_1");
                context.SetTimer(timerId: "1", seconds: 2);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State예고이펙트(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State예고이펙트 : TriggerState {
            internal State예고이펙트(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8804}, returnView: true);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetAchievement(triggerId: 999, type: "trigger", code: "Bellafirst");
                context.SetEffect(triggerIds: new []{8001, 8002, 8003, 8004, 8005, 8006, 8007, 8008, 8009, 8010, 8011, 8012}, visible: true);
                context.SetTimer(timerId: "2", seconds: 2);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "2")) {
                    return new StateSkill시작Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill시작Wait : TriggerState {
            internal StateSkill시작Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 20002522, textId: 20002522);
                context.SetMesh(triggerIds: new []{151, 152, 153, 154, 155, 156}, visible: false);
                context.CreateMonster(spawnIds: new []{1051, 1052, 1053, 1054, 1055, 1056, 1057, 1058, 1059, 1060, 1061, 1062}, arg2: false);
                context.SetTimer(timerId: "3", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    context.DestroyMonster(spawnIds: new []{1001});
                    return new StateSkill시작Wait2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill시작Wait2 : TriggerState {
            internal StateSkill시작Wait2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "2", seconds: 2);
                context.SetEffect(triggerIds: new []{8001, 8002, 8003, 8004, 8005, 8006, 8007, 8008, 8009, 8010, 8011, 8012}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "2")) {
                    return new StateSkill08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill08 : TriggerState {
            internal StateSkill08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 1);
                context.SetSkill(triggerIds: new []{515, 516, 517, 518, 519, 520, 521, 522, 523, 524, 525, 526}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateSkill07Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill07Wait : TriggerState {
            internal StateSkill07Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{515, 516, 517, 518, 519, 520, 521, 522, 523, 524, 525, 526}, arg2: false);
            }

            public override TriggerState? Execute() {
                return new StateSkill07(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill07 : TriggerState {
            internal StateSkill07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 1);
                context.SetSkill(triggerIds: new []{564, 517, 518, 519, 520, 521, 522, 523, 524, 525, 526, 527, 528, 529, 530, 531}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateSkill06Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill06Wait : TriggerState {
            internal StateSkill06Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{564, 517, 518, 519, 520, 521, 522, 523, 524, 525, 526, 527, 528, 529, 530, 531}, arg2: false);
            }

            public override TriggerState? Execute() {
                return new StateSkill06(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill06 : TriggerState {
            internal StateSkill06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 1);
                context.SetSkill(triggerIds: new []{565, 564, 522, 523, 524, 525, 526, 527, 528, 529, 530, 531, 532, 533, 534, 535, 536}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateSkill05Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill05Wait : TriggerState {
            internal StateSkill05Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 20002522);
                context.SetSkill(triggerIds: new []{565, 564, 522, 523, 524, 525, 526, 527, 528, 529, 530, 531, 532, 533, 534, 535, 536}, arg2: false);
            }

            public override TriggerState? Execute() {
                return new StateSkill05(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill05 : TriggerState {
            internal StateSkill05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 1);
                context.SetSkill(triggerIds: new []{566, 567, 568, 565, 564, 527, 528, 529, 530, 531, 532, 533, 534, 535, 536, 537, 538, 539}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateSkill04Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill04Wait : TriggerState {
            internal StateSkill04Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{566, 567, 568, 565, 564, 527, 528, 529, 530, 531, 532, 533, 534, 535, 536, 537, 538, 539}, arg2: false);
            }

            public override TriggerState? Execute() {
                return new StateSkill04(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill04 : TriggerState {
            internal StateSkill04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 1);
                context.SetSkill(triggerIds: new []{566, 567, 568}, arg2: false);
                context.SetSkill(triggerIds: new []{565, 532, 533, 534, 535, 536, 537, 538, 539, 540, 541, 542, 543, 544, 545}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateSkill03Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill03Wait : TriggerState {
            internal StateSkill03Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{566, 567, 568, 565, 532, 533, 534, 535, 536, 537, 538, 539, 540, 541, 542, 543, 544, 545}, arg2: false);
            }

            public override TriggerState? Execute() {
                return new StateSkill03(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill03 : TriggerState {
            internal StateSkill03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 1);
                context.SetSkill(triggerIds: new []{566, 567, 568, 537, 538, 539, 540, 541, 542, 543, 544, 545, 546, 547, 548, 549, 550, 551}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateSkill02Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill02Wait : TriggerState {
            internal StateSkill02Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{566, 567, 568, 537, 538, 539, 540, 541, 542, 543, 544, 545, 546, 547, 548, 549, 550, 551}, arg2: false);
            }

            public override TriggerState? Execute() {
                return new StateSkill02(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill02 : TriggerState {
            internal StateSkill02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 1);
                context.SetSkill(triggerIds: new []{540, 541, 542, 543, 544, 545, 546, 547, 548, 549, 550, 551, 552, 553, 554, 555, 556, 557}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateSkill01Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill01Wait : TriggerState {
            internal StateSkill01Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{540, 541, 542, 543, 544, 545, 546, 547, 548, 549, 550, 551, 552, 553, 554, 555, 556, 557}, arg2: false);
            }

            public override TriggerState? Execute() {
                return new StateSkill01(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill01 : TriggerState {
            internal StateSkill01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 1);
                context.SetSkill(triggerIds: new []{546, 547, 548, 549, 550, 551, 552, 553, 554, 555, 556, 557, 558, 559, 560, 561, 562, 563}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateSkill00Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill00Wait : TriggerState {
            internal StateSkill00Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{546, 547, 548, 549, 550, 551, 552, 553, 554, 555, 556, 557, 558, 559, 560, 561, 562, 563}, arg2: false);
            }

            public override TriggerState? Execute() {
                return new StateSkill00(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill00 : TriggerState {
            internal StateSkill00(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 1);
                context.SetSkill(triggerIds: new []{552, 553, 554, 555, 556, 557, 558, 559, 560, 561, 562, 563, 301, 302, 303, 304, 305, 306}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateSkill0_5Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill0_5Wait : TriggerState {
            internal StateSkill0_5Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{552, 553, 554, 555, 556, 557, 558, 559, 560, 561, 562, 563, 301, 302, 303, 304, 305, 306}, arg2: false);
            }

            public override TriggerState? Execute() {
                return new StateSkill0_5(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill0_5 : TriggerState {
            internal StateSkill0_5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 1);
                context.SetSkill(triggerIds: new []{558, 559, 560, 561, 562, 563, 301, 302, 303, 304, 305, 306, 307, 308, 309, 310, 311, 312}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateSkill01Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill08Wait : TriggerState {
            internal StateSkill08Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{341, 342, 343, 344, 345, 346, 347, 348, 349, 350, 351, 352, 353, 354, 355, 356, 357, 358}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000409}, arg2: 0)) {
                    return new State굳음(context);
                }

                return new StateSkill08(context);
            }

            public override void OnExit() { }
        }

        private class State굳음 : TriggerState {
            internal State굳음(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "20", seconds: 20);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "20")) {
                    return new StateSkill08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill09Wait : TriggerState {
            internal StateSkill09Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{347, 348, 349, 350, 351, 352, 353, 354, 355, 356, 357, 358, 359, 360, 361, 362, 363, 364}, arg2: false);
            }

            public override TriggerState? Execute() {
                return new StateSkill09(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill09 : TriggerState {
            internal StateSkill09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 1);
                context.SetSkill(triggerIds: new []{353, 354, 355, 356, 357, 358, 359, 360, 361, 362, 363, 364, 365, 366, 367, 368, 369, 370}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateSkill10Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill10Wait : TriggerState {
            internal StateSkill10Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{353, 354, 355, 356, 357, 358, 359, 360, 361, 362, 363, 364, 365, 366, 367, 368, 369, 370}, arg2: false);
            }

            public override TriggerState? Execute() {
                return new StateSkill10(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill10 : TriggerState {
            internal StateSkill10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 1);
                context.SetSkill(triggerIds: new []{359, 360, 361, 362, 363, 364, 365, 366, 367, 368, 369, 370, 371, 372, 373, 374, 375, 376}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateSkill11Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill11Wait : TriggerState {
            internal StateSkill11Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 0);
                context.SetSkill(triggerIds: new []{359, 360, 361, 362, 363, 364, 365, 366, 367, 368, 369, 370, 371, 372, 373, 374, 375, 376}, arg2: false);
            }

            public override TriggerState? Execute() {
                return new StateSkill12(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill12 : TriggerState {
            internal StateSkill12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 1);
                context.SetSkill(triggerIds: new []{365, 366, 367, 368, 369, 370, 371, 372, 373, 374, 375, 376, 377, 378, 379, 380, 381, 382}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateSkill13Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill13Wait : TriggerState {
            internal StateSkill13Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{365, 366, 367, 368, 369, 370, 371, 372, 373, 374, 375, 376, 377, 378, 379, 380, 381, 382}, arg2: false);
            }

            public override TriggerState? Execute() {
                return new StateSkill13(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill13 : TriggerState {
            internal StateSkill13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 1);
                context.SetSkill(triggerIds: new []{371, 372, 373, 374, 375, 376, 377, 378, 379, 380, 381, 382, 383, 384, 385, 386, 387, 388}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateSkill14Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill14Wait : TriggerState {
            internal StateSkill14Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{371, 372, 373, 374, 375, 376, 377, 378, 379, 380, 381, 382, 383, 384, 385, 386, 387, 388}, arg2: false);
            }

            public override TriggerState? Execute() {
                return new StateSkill14(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill14 : TriggerState {
            internal StateSkill14(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 1);
                context.SetSkill(triggerIds: new []{377, 378, 379, 380, 381, 382, 383, 384, 385, 386, 387, 388, 389, 390, 391, 392, 393, 394, 395}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateSkill15Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill15Wait : TriggerState {
            internal StateSkill15Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{377, 378, 379, 380, 381, 382, 383, 384, 385, 386, 387, 388, 389, 390, 391, 392, 393, 394, 395}, arg2: false);
            }

            public override TriggerState? Execute() {
                return new StateSkill15(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill15 : TriggerState {
            internal StateSkill15(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 1);
                context.SetSkill(triggerIds: new []{383, 384, 385, 386, 387, 388, 389, 390, 391, 392, 393, 394, 395, 396, 397, 398, 399, 400, 401, 402}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateSkill16Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill16Wait : TriggerState {
            internal StateSkill16Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{383, 384, 385, 386, 387, 388, 389, 390, 391, 392, 393, 394, 395, 396, 397, 398, 399, 400, 401, 402}, arg2: false);
            }

            public override TriggerState? Execute() {
                return new StateSkill16(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill16 : TriggerState {
            internal StateSkill16(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 1);
                context.SetSkill(triggerIds: new []{389, 390, 391, 392, 393, 394, 395, 396, 397, 398, 399, 400, 401, 402, 403, 404, 405, 406, 407, 408, 409}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateSkill17Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill17Wait : TriggerState {
            internal StateSkill17Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{389, 390, 391, 392, 393, 394, 395, 396, 397, 398, 399, 400, 401, 402, 403, 404, 405, 406, 407, 408, 409}, arg2: false);
            }

            public override TriggerState? Execute() {
                return new StateSkill17(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill17 : TriggerState {
            internal StateSkill17(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 1);
                context.SetSkill(triggerIds: new []{396, 397, 398, 399, 400, 401, 402, 403, 404, 405, 406, 407, 408, 409, 410, 411, 412, 413, 414, 415, 416}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateSkill18Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill18Wait : TriggerState {
            internal StateSkill18Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{396, 397, 398, 399, 400, 401, 402, 403, 404, 405, 406, 407, 408, 409, 410, 411, 412, 413, 414, 415, 416}, arg2: false);
            }

            public override TriggerState? Execute() {
                return new StateSkill18(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill18 : TriggerState {
            internal StateSkill18(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 1);
                context.SetSkill(triggerIds: new []{403, 404, 405, 406, 407, 408, 409, 410, 411, 412, 413, 414, 415, 416, 417, 418, 419, 420, 421, 422}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateSkill19Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill19Wait : TriggerState {
            internal StateSkill19Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{403, 404, 405, 406, 407, 408, 409, 410, 411, 412, 413, 414, 415, 416, 417, 418, 419, 420, 421, 422}, arg2: false);
            }

            public override TriggerState? Execute() {
                return new StateSkill19(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill19 : TriggerState {
            internal StateSkill19(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 1);
                context.SetSkill(triggerIds: new []{410, 411, 412, 413, 414, 415, 416, 417, 418, 419, 420, 421, 422, 423, 424, 425, 426, 427, 428}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateSkill20Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill20Wait : TriggerState {
            internal StateSkill20Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{410, 411, 412, 413, 414, 415, 416, 417, 418, 419, 420, 421, 422, 423, 424, 425, 426, 427, 428}, arg2: false);
            }

            public override TriggerState? Execute() {
                return new StateSkill20(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill20 : TriggerState {
            internal StateSkill20(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 1);
                context.SetSkill(triggerIds: new []{417, 418, 419, 420, 421, 422, 423, 424, 425, 426, 427, 428, 429, 430, 431, 432, 433, 434}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateSkill21Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill21Wait : TriggerState {
            internal StateSkill21Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{417, 418, 419, 420, 421, 422, 423, 424, 425, 426, 427, 428, 429, 430, 431, 432, 433, 434}, arg2: false);
            }

            public override TriggerState? Execute() {
                return new StateSkill21(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill21 : TriggerState {
            internal StateSkill21(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 1);
                context.SetSkill(triggerIds: new []{423, 424, 425, 426, 427, 428, 429, 430, 431, 432, 433, 434, 435, 436, 437, 438, 439, 440}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateSkill22Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill22Wait : TriggerState {
            internal StateSkill22Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{423, 424, 425, 426, 427, 428, 429, 430, 431, 432, 433, 434, 435, 436, 437, 438, 439, 440}, arg2: false);
            }

            public override TriggerState? Execute() {
                return new StateSkill22(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill22 : TriggerState {
            internal StateSkill22(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 1);
                context.SetSkill(triggerIds: new []{429, 430, 431, 432, 433, 434, 435, 436, 437, 438, 439, 440, 441, 442, 443, 444, 445, 446}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateSkill23Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill23Wait : TriggerState {
            internal StateSkill23Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{429, 430, 431, 432, 433, 434, 435, 436, 437, 438, 439, 440, 441, 442, 443, 444, 445, 446}, arg2: false);
            }

            public override TriggerState? Execute() {
                return new StateSkill23(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill23 : TriggerState {
            internal StateSkill23(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 1);
                context.SetSkill(triggerIds: new []{435, 436, 437, 438, 439, 440, 441, 442, 443, 444, 445, 446, 447, 448, 449, 450, 451, 452}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateSkill24Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill24Wait : TriggerState {
            internal StateSkill24Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{435, 436, 437, 438, 439, 440, 441, 442, 443, 444, 445, 446, 447, 448, 449, 450, 451, 452}, arg2: false);
            }

            public override TriggerState? Execute() {
                return new StateSkill24(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill24 : TriggerState {
            internal StateSkill24(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 1);
                context.SetSkill(triggerIds: new []{441, 442, 443, 444, 445, 446, 447, 448, 449, 450, 451, 452, 453, 454, 455, 456, 457, 458}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateSkill25Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill25Wait : TriggerState {
            internal StateSkill25Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{441, 442, 443, 444, 445, 446, 447, 448, 449, 450, 451, 452, 453, 454, 455, 456, 457, 458}, arg2: false);
            }

            public override TriggerState? Execute() {
                return new StateSkill25(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill25 : TriggerState {
            internal StateSkill25(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 1);
                context.SetSkill(triggerIds: new []{447, 448, 449, 450, 451, 452, 453, 454, 455, 456, 457, 458, 459, 460, 461, 462, 463, 464}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateSkill26Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill26Wait : TriggerState {
            internal StateSkill26Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{447, 448, 449, 450, 451, 452, 453, 454, 455, 456, 457, 458, 459, 460, 461, 462, 463, 464}, arg2: false);
            }

            public override TriggerState? Execute() {
                return new StateSkill26(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill26 : TriggerState {
            internal StateSkill26(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 1);
                context.SetSkill(triggerIds: new []{453, 454, 455, 456, 457, 458, 459, 460, 461, 462, 463, 464, 465, 466, 467, 468, 469, 470}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateSkill27Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill27Wait : TriggerState {
            internal StateSkill27Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{453, 454, 455, 456, 457, 458, 459, 460, 461, 462, 463, 464, 465, 466, 467, 468, 469, 470}, arg2: false);
            }

            public override TriggerState? Execute() {
                return new StateSkill27(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill27 : TriggerState {
            internal StateSkill27(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 1);
                context.SetSkill(triggerIds: new []{459, 460, 461, 462, 463, 464, 465, 466, 467, 468, 469, 470, 471, 472, 473, 474, 475, 476, 477}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateSkill28Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill28Wait : TriggerState {
            internal StateSkill28Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{459, 460, 461, 462, 463, 464, 465, 466, 467, 468, 469, 470, 471, 472, 473, 474, 475, 476, 477}, arg2: false);
            }

            public override TriggerState? Execute() {
                return new StateSkill28(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill28 : TriggerState {
            internal StateSkill28(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 1);
                context.SetSkill(triggerIds: new []{465, 466, 467, 468, 469, 470, 471, 472, 473, 474, 475, 476, 477, 478, 479, 480, 481, 482, 483, 484}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateSkill29Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill29Wait : TriggerState {
            internal StateSkill29Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{465, 466, 467, 468, 469, 470, 471, 472, 473, 474, 475, 476, 477, 478, 479, 480, 481, 482, 483, 484}, arg2: false);
            }

            public override TriggerState? Execute() {
                return new StateSkill29(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill29 : TriggerState {
            internal StateSkill29(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 1);
                context.SetSkill(triggerIds: new []{471, 472, 473, 474, 475, 476, 477, 478, 479, 480, 481, 482, 483, 484, 485, 486, 487, 488, 489, 490}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateSkill30Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill30Wait : TriggerState {
            internal StateSkill30Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{471, 472, 473, 474, 475, 476, 477, 478, 479, 480, 481, 482, 483, 484, 485, 486, 487, 488, 489, 490}, arg2: false);
            }

            public override TriggerState? Execute() {
                return new StateSkill30(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill30 : TriggerState {
            internal StateSkill30(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 1);
                context.SetSkill(triggerIds: new []{478, 479, 480, 481, 482, 483, 484, 485, 486, 487, 488, 489, 490, 491, 492, 493, 494, 495, 496}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateSkill31Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill31Wait : TriggerState {
            internal StateSkill31Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{478, 479, 480, 481, 482, 483, 484, 485, 486, 487, 488, 489, 490, 491, 492, 493, 494, 495, 496}, arg2: false);
            }

            public override TriggerState? Execute() {
                return new StateSkill31(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill31 : TriggerState {
            internal StateSkill31(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 1);
                context.SetSkill(triggerIds: new []{485, 486, 487, 488, 489, 490, 491, 492, 493, 494, 495, 496, 497, 498, 499, 500, 501, 502}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateSkill32Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill32Wait : TriggerState {
            internal StateSkill32Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{485, 486, 487, 488, 489, 490, 491, 492, 493, 494, 495, 496, 497, 498, 499, 500, 501, 502}, arg2: false);
            }

            public override TriggerState? Execute() {
                return new StateSkill32(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill32 : TriggerState {
            internal StateSkill32(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 1);
                context.SetSkill(triggerIds: new []{491, 492, 493, 494, 495, 496, 497, 498, 499, 500, 501, 502, 503, 504, 505, 506, 507, 508}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateSkill33Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill33Wait : TriggerState {
            internal StateSkill33Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 0);
                context.SetSkill(triggerIds: new []{491, 492, 493, 494, 495, 496, 497, 498, 499, 500, 501, 502, 503, 504, 505, 506, 507, 508}, arg2: false);
            }

            public override TriggerState? Execute() {
                return new StateSkill33(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill33 : TriggerState {
            internal StateSkill33(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 1);
                context.SetSkill(triggerIds: new []{497, 498, 499, 500, 501, 502, 503, 504, 505, 506, 507, 508, 509, 510, 511, 512, 513, 514}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State끝(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State끝 : TriggerState {
            internal State끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{497, 498, 499, 500, 501, 502, 503, 504, 505, 506, 507, 508, 509, 510, 511, 512, 513, 514}, arg2: false);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
